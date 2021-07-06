#r "nuget: XPlot.Plotly, 4.0.3"

open System.Numerics


let f (n : int32) (s: Complex) = Complex.One / (Complex(n |> float, 0.0) ** s) 

let iterations = 100

let zseq s : seq<Complex> = 
  [1..iterations]
  |> Seq.map (fun n -> f n s)

let zagg (s : Complex) : (seq<Complex>) = 
  s
  |> zseq
  |> Seq.scan (fun (state : Complex) x -> (x + state)) (Complex.Zero)
  
let z s = 
   zseq s |> Seq.fold ( + ) Complex.Zero


let printfunction fn sequence = 
  sequence
  |> fn
  |> Seq.iteri(fun i x -> printfn "%d : %A" i x)

//printfunction zseq 2.0

printfunction zagg (Complex(2.0, 0.0))

(System.Math.PI ** 2.0) / 6.0

// open XPlot.Plotly

// let results = zagg 2.0
// results |> Chart.Line |> Chart.Show
