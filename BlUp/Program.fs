namespace BlUp

open BlUp.Up
open MBrace.FsPickler

module App =

    let resultToExit =
        both (fun _ -> 0) (fun _ -> 1)

    [<EntryPoint>]
    let main argv =
        match argv |> Array.toList with
        | "ups" :: [ name; containerName; connectionString ] ->
            Az.createContainer connectionString containerName
            <!> (fun _ -> Config.getConfig Config.localPath)
            <!> (Map.add
                     name
                     { storageConnString = connectionString
                       containerName = containerName })
            >>= Config.saveConfig Config.localPath
            |> logResult
            |> resultToExit
        | [ "ls" ] ->
            Config.getConfig Config.localPath
            |> Map.keys
            |> Seq.iter logSuccess

            0
        | [ "rm"; name ] ->
            Config.getConfig Config.localPath
            |> Map.remove name
            |> Config.saveConfig Config.localPath
            |> logResult
            |> resultToExit
        | [ "help" ] ->
            logSuccess "Usage: blup COMMAND [ARGUMENTS]"
            logSuccess "Commands:"
            logSuccess "  ups       Add or update blob storage settings"
            logSuccess "            Usage: blup ups %name% %container name% %blob account connection string%"
            logSuccess "  rm        Remove blob storage settings"
            logSuccess "            Usage: blup rem %name%"
            logSuccess "  ls        List all registered blob storage settings"
            logSuccess "            Usage: blup list"
            logSuccess "  sync      Sync local directory with blob storage"
            logSuccess "            Usage: blup sync %name% %src path%"
            0
        | [ "sync"; name; path ] ->
            Config.getConfig Config.localPath
            |> Map.tryFind name
            |> ofOption $"Blob account %s{name} not found."
            >>= sync path
            |> logResult
            |> resultToExit
        | cmd :: _ ->
            logError $"'%s{cmd}' is not a valid command."
            logError "See 'blup help'"
            1
        | [] ->
            logError "No valid command passed."
            logError "See 'blup help'"
            1
