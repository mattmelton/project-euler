open System

let reverse (s:string) = new string(Array.rev (s.ToCharArray()))

let getSequence limit =
    seq { for i in 1..limit do for j in 1..limit do yield (i*j) }

let isPalendrome (s: string) =
    match s.Length % 2 with
        | 0 -> s.Substring(0, s.Length / 2) |> reverse = s.Substring(s.Length / 2)
        | _ -> s.Substring(0, (s.Length - 1) / 2) |> reverse = s.Substring((s.Length + 1) / 2)
    
let r =
    getSequence 999
    |> Seq.where(fun (x) -> isPalendrome (string x) )
    |> Seq.max
        