open System

let getSequence limit =
    seq { 
        for a in 1..limit do 
            for b in 1..limit do 
                for c in 1..limit do
                    if a + b + c = limit then yield (a, b, c) }

let isPythagorianTriplet a b c =
    a*a + b*b = c*c
        
let r limit = 
    getSequence limit
    |> Seq.filter(fun (a, b, c) -> isPythagorianTriplet a b c)        
    |> Seq.map(fun (a, b, c) -> (a, b, c, a * b * c))
    |> Seq.head

printfn "Result: %A" (r 1000)