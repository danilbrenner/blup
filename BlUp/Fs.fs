namespace BlUp

open System.IO
open System.Security.Cryptography

module Fs =

    let private readFileInternal path file =
        let filePath =
            Path.Combine([| path; file |])

        use fileStream =
            File.Open(filePath, FileMode.Open)

        let memoryStream = new MemoryStream()
        fileStream.CopyTo(memoryStream)
        fileStream.Close()
        memoryStream.ToArray()
    
    let readFile path = readFileInternal path |> tryCatch
    
    let writeFile fPath =
        (fun bytes -> File.WriteAllBytes(fPath, bytes))
        |> tryCatch
        
    let private listFilesInternal path =
        Directory.GetFiles(path, "*", SearchOption.AllDirectories)
        |> Array.map (fun s -> s.Remove(0, path.Length + 1))

    let listFiles =
        listFilesInternal |> tryCatch

    let md5 (data: byte array) : byte array =
        use md5 = MD5.Create()
        data |> md5.ComputeHash
