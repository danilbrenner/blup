namespace BlUp

[<AutoOpen>]
module Common =
    let flip f a b = f b a

    let tryCatch (f: 'a -> 'b) (v: 'a) : Result<'b, string> =
        try
            f v |> Ok
        with exp ->
            Error exp.Message
