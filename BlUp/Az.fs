namespace BlUp

open System
open Azure.Storage.Blobs
open Azure.Storage.Blobs.Models

module Az =

    let unwrapResp (resp: Azure.Response<'a>) = resp.Value
    
    let createContainer (storageConnString: string) (containerName: string) =
        try
            let container =
                BlobContainerClient(storageConnString, containerName)

            container.CreateIfNotExists() |> ignore
            Ok container
        with
        | exp -> exp.Message |> Error

    let uploadContent (blob: BlobClient) (bytes: byte array) =
        let act (b: byte array) = BinaryData b |> blob.Upload
        tryCatch act bytes
        <!> unwrapResp

    let removeContent (blob: BlobClient) = tryCatch blob.Delete ()

    let setProperties (blob: BlobClient) hash contentType =
        fun _ ->
            let headers = BlobHttpHeaders()
            headers.ContentType <- contentType
            headers.ContentHash <- hash
            blob.SetHttpHeaders headers |> ignore
            blob
        |> flip tryCatch ()