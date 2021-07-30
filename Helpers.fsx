open System.Numerics

let initInfinite next initial = initial |> Seq.unfold(fun c -> Some(c, next(c) ))
 
let increment (x : Complex) : Complex = x + Complex(1.0,0.0)

// Complex(0.0, 0.0)
// |> initInfinite increment
// |> Seq.take 4
