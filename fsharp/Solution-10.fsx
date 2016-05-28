open System

let getSequence limit =
    seq { 2L..limit }
    
let isPrime n =
    let sqrt' = (float >> sqrt >> int64) n
    [ 2L .. sqrt' ]
    |> List.forall (fun x -> n % x <> 0L)
        
let r limit = 
    getSequence limit
    |> Seq.filter(fun (i) -> isPrime i)        
    |> Seq.reduce (fun acc elem -> acc + elem) 

printfn "Result: %A" (r 2000000L)