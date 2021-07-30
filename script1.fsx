open System.Numerics

#r "nuget: XPlot.Plotly"
open XPlot.Plotly

#load "Zeta.fsx"
open Zeta

let printfunction fn sequence = 
  sequence
  |> fn
  |> Seq.iteri(fun i x -> printfn "%d : %A" i x)


let toPlotPoints (cseq: seq<Complex>) =  cseq |> Seq.map (fun x -> x.Real, x.Imaginary )

// zetaSeqCumulative (Complex(2.0, 2.0))
// |> toPlotPoints
// |> Chart.Line |> Chart.Show

// seq[1..100]
// |> Seq.map(fun i -> Complex(i |> float, 0.0))

// Seq.initInfinite(fun i -> (i |> float) / 100.0 )
// |> Seq.take 1000
// |> Seq.map(fun f -> Complex(f, -1.0))
// |> Seq.map(fun c -> c, c |> zeta)
// |> Seq.map(fun (s,fs) -> (s.Magnitude, fs.Magnitude))
// |> Chart.Scatter |> Chart.Show


Complex(0.0, 0.0)
|> Seq.unfold(fun c -> Some(c, c + Complex(0.1, 0.0 ) ))
|> Seq.take 10
//|> Seq.takeWhile(fun c -> c.Real < 10.0)
|> Seq.map(fun c -> c, c |> zeta)
|> Seq.map(fun (s,fs) -> (s.Magnitude, fs.Magnitude))
|> Chart.Scatter |> Chart.Show


// Complex(1.0, 0.0) * Complex(Math.Cos(PI / 4.0), Math.Sin( PI / 4.0))
