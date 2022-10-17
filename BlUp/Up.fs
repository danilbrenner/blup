namespace BlUp

open System
open Azure.Storage.Blobs
open Azure.Storage.Blobs.Models

module Up =
    type AzureSettings =
        { storageConnString: string
          containerName: string }
    
    let addFile (container: BlobContainerClient) path file =
        let blob = container.GetBlobClient file
        Fs.readFile path file
        >>= Az.uploadContent blob
        >>= (fun info -> blob.Name |> MimeTypes.getFileContentType |> Az.setProperties blob info.ContentHash)
        <!> (fun _ -> $"{file} added")

    let updateBlob (container: BlobContainerClient) path (item: BlobItem) =
        result {
            let! bytes = Fs.readFile path item.Name
            let md5Hash = Fs.md5 bytes
            if md5Hash = item.Properties.ContentHash then
                return $"{item.Name} equal"
            else
                let blob = container.GetBlobClient item.Name
                return!
                    Az.removeContent blob
                    >>= (fun _ -> Az.uploadContent blob bytes)
                    >>= (fun info -> blob.Name |> MimeTypes.getFileContentType |> Az.setProperties blob info.ContentHash)
                    <!> (fun _ -> $"{item.Name} updated")
        }
    
    let logWColor color msg =
        Console.ForegroundColor <- color
        printfn $"%s{msg}"
        Console.ResetColor()
    
    let logSuccess = logWColor ConsoleColor.Green
        
    let logError = logWColor ConsoleColor.Red
    
    let logResult =
        function
            | Ok msg ->
                logSuccess msg
                Ok msg
            | Error msg ->
                logError msg
                Error msg

    let removeBlob (container: BlobContainerClient) (item: BlobItem) =
        item.Name
        |> container.GetBlobClient
        |> Az.removeContent
        <!> (fun _ -> $"{item.Name} removed")
    
    let sync basePath settings =
        match Fs.listFiles basePath, Az.createContainer settings.storageConnString settings.containerName with
        | Ok list, Ok container ->
            let blobs =
                container.GetBlobs()
                |> Seq.filter (fun itm -> itm.Deleted |> not)
                |> Seq.toArray
                |> Array.sortBy (fun i -> i.Name)

            let files = list |> Array.sortBy id

            let toAdd, toUpdate, toRemove =
                MergeJoin.mj id (fun (b: BlobItem) -> b.Name) files blobs

            toAdd
            |> List.iter (addFile container basePath >> logResult >> ignore)
            
            toUpdate
            |> List.iter (snd >> (updateBlob container basePath) >> logResult >> ignore)
            
            toRemove
            |> List.iter (removeBlob container >> logResult >> ignore)
            
            Ok "Sync compleeted"
        | Error err, Ok _ -> Error err
        | _, Error err -> Error err