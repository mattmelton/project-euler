let s = Seq.unfold(fun (a,b) -> Some(a + b, (b, a + b))) (0, 1)

let isEven n =
    n % 2 = 0
    
let r = 
    s |> Seq.filter isEven
      |> Seq.takeWhile(fun(x) -> x < 4000000)
      |> Seq.sum
  
