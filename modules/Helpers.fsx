open System.Numerics
open System

let initInfinite next initial = initial |> Seq.unfold(fun c -> Some(c, next(c) ))
 
let increment (x : Complex) : Complex = x + Complex(1.0,0.0)

let PI = Math.PI

// Complex(0.0, 0.0)
// |> initInfinite increment
// |> Seq.take 4


let unzip (s: seq<'T1 * 'T2>) =
  let it1, it2 = 
      s 
      |> List.ofSeq 
      |> List.unzip 
  (Seq.ofList it1, Seq.ofList it2)
  