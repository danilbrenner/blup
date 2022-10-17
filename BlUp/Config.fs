namespace BlUp

open System.IO
open BlUp.Up
open Fs
open MBrace.FsPickler

module Config =
    
    type AzureSettingsSet = Map<string, AzureSettings>
    
    let deserializeSettings  =
        let ser = FsPickler.CreateBinarySerializer()
        ser.UnPickle<AzureSettingsSet>
    
    let serializeSettings v =
        let ser = FsPickler.CreateBinarySerializer()
        ser.Pickle v
    
    let localPath =
        System.Reflection.Assembly.GetExecutingAssembly().Location
        |> Path.GetDirectoryName
    
    let fileName = "settings.cfg"
    
    let getConfig path =
        readFile path fileName
        <!> deserializeSettings
        |> both id (fun _ -> Map.empty)
        
    let saveConfig path (settings: AzureSettingsSet) =
        (Path.Combine [|path; fileName|], serializeSettings settings)
        ||> writeFile
        <!> fun _ -> "Settings saved"