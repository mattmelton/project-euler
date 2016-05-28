open System

let getNumbers limit =
    seq { 1 .. limit }
    
let a limit = 
    getNumbers limit
        |> Seq.map(fun(x) -> x * x)
        |> Seq.take(limit)
        |> Seq.sum
        
let b limit = 
    let sum = 
        getNumbers limit
        |> Seq.take(limit)
        |> Seq.sum
    sum * sum
    
(b 100) - (a 100)
        