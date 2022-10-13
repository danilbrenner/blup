open System
open Azure.Storage.Blobs
open Azure.Storage.Blobs.Models
open BlUp

type AzureSettings =
    { storageConnString: string
      containerName: string
      basePath: string }

let settings =
    { storageConnString = ""
      containerName = ""
      basePath = "" }

let addFile (container: BlobContainerClient) path file =
    let blob = container.GetBlobClient file
    Fs.readFile path file
    >>= Az.uploadContent blob
    >>= (fun _ -> blob.Name |> MimeTypes.getFileContentType |> Az.setContentType blob)
    <!> (fun _ -> $"{file} added")

let updateBlob (container: BlobContainerClient) path (item: BlobItem) =
    result {
        let! bytes = Fs.readFile path item.Name
        if Fs.md5 bytes = item.Properties.ContentHash then
            return $"{item.Name} equal"
        else
            let blob = container.GetBlobClient item.Name
            return!
                Az.removeContent blob
                >>= (fun _ -> Az.uploadContent blob bytes)
                >>= (fun _ -> blob.Name |> MimeTypes.getFileContentType |> Az.setContentType blob)
                <!> (fun _ -> $"{item.Name} updated")
    }

let logResult =
    function
        | Ok msg ->
            Console.ForegroundColor <- ConsoleColor.Green
            printfn $"%s{msg}"
            Console.ResetColor()
        | Error msg ->
            Console.ForegroundColor <- ConsoleColor.Red
            printfn $"%s{msg}"
            Console.ResetColor()

let removeBlob (container: BlobContainerClient) (item: BlobItem) =
    item.Name
    |> container.GetBlobClient
    |> Az.removeContent
    <!> (fun _ -> $"{item.Name} removed")
    
match Fs.listFiles settings.basePath, Az.createContainer settings.storageConnString settings.containerName with
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
    |> List.iter (addFile container settings.basePath >> logResult)
    
    toUpdate
    |> List.iter (snd >> (updateBlob container settings.basePath) >> logResult)
    
    toRemove
    |> List.iter (removeBlob container >> logResult)
    
    exit 0
| Error err, Ok _ ->
    err |> Error |> logResult
    exit 1
| _, Error err ->
    err |> Error |> logResult
    exit 1
