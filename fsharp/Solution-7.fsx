open System

let isPrime n =
    let sqrt' = (float >> sqrt >> int64) n
    [ 2L .. sqrt' ]
    |> List.forall (fun x -> n % x <> 0L)

Seq.initInfinite (fun n -> int64 n + 1L)
    |> Seq.where(fun (x) -> isPrime x)
    |> Seq.skip(10001)
    |> Seq.head
