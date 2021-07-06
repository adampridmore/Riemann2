#r "nuget: XPlot.Plotly"

open System.Numerics
open XPlot.Plotly

let f (n : int32) (s: Complex) = Complex.One / (Complex(n |> float, 0.0) ** s) 

let iterations = 100

let zseq s : seq<Complex> = 
  [1..iterations]
  |> Seq.map (fun n -> f n s)

let zagg (s : Complex) : (seq<Complex>) = 
  s
  |> zseq
  |> Seq.scan (fun (state : Complex) x -> (x + state)) (Complex.Zero)
  |> Seq.skip 1
  
let z s = 
   zseq s |> Seq.fold ( + ) Complex.Zero


let printfunction fn sequence = 
  sequence
  |> fn
  |> Seq.iteri(fun i x -> printfn "%d : %A" i x)


//printfunction zagg (Complex(2.0, 0.0))
//(System.Math.PI ** 2.0) / 6.0


let toPlotPoints (cseq: seq<Complex>) =  cseq |> Seq.map (fun x -> x.Real, x.Imaginary )

zagg (Complex(2.0, 2.0))
|> toPlotPoints
|> Chart.Line |> Chart.Show
