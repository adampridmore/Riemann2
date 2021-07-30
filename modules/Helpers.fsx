open System.Numerics
open System

let initInfinite next initial = initial |> Seq.unfold(fun c -> Some(c, next(c) ))
 
let increment (x : Complex) : Complex = x + Complex(1.0,0.0)

let PI = Math.PI

// Complex(0.0, 0.0)
// |> initInfinite increment
// |> Seq.take 4
