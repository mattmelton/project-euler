open System

let isDivisible n limit =
    seq { limit .. -1 .. 2}
        |> Seq.forall(fun (x) -> n % x = 0)

let r limit = 
    Seq.initInfinite(fun(x) -> x + 1)
        |> Seq.find(fun (x) -> isDivisible x limit)