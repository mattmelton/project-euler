open System

let numSequnce limit = seq { limit .. -1L .. 3L }

let isPrime n =
    let sqrt' = (float >> sqrt >> int64) n
    [ 2L .. sqrt' ]
    |> List.forall (fun x -> n % x <> 0L)
  
let isFactor limit n =
    limit % n = 0L
    
let calc n = 
    let limit = int64(Math.Sqrt(double(n)))
    numSequnce limit
    |> Seq.filter(fun (x) -> isPrime x)
    |> Seq.filter(fun (x) -> isFactor n x) 
    |> Seq.head
     
// Takes ~ 20s to run
let r = calc 600851475143L