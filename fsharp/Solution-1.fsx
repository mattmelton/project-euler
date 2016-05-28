let s = seq { 1 .. (1000 - 1) }

let isMultiple35 n =
    match n with
    | x when x % 3 = 0 -> true
    | x when x % 5 = 0 -> true
    | _ -> false    
      
let ac =
    s |> Seq.where(fun x -> isMultiple35 x)
      |> Seq.sum
 


