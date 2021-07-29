#r "nuget: XPlot.Plotly"

open XPlot.Plotly
open System.Numerics
open System

let PI = Math.PI

let toPlotPoints (cseq: seq<Complex>) = 
  cseq 
  |> Seq.map (fun x -> x.Real, x.Imaginary )
  |> Seq.toList
  |> List.unzip

let s =
  Complex(1.0, 0.0)
  |> Seq.unfold(fun c -> Some(c, c * Complex(Math.Cos(PI / 4.0), Math.Sin( PI / 4.0)) ))
  |> Seq.take 10

let fn s = s + Complex(1.0,0.0)

// let graphFns (fn : Complex -> Complex) (s : seq<Complex>) : Unit =
//   ()

let s2 = s |> Seq.map fn

let points1 = s |> toPlotPoints 
let points2 = s2 |> toPlotPoints

let scatter1 =
  Scatter(
      x = (points1 |> fst),
      y = (points1 |> snd),
      name = "s"
  )

let scatter2 =
  Scatter(
      x = (points2 |> fst),
      y = (points2 |> snd),
      name = "fn(s)"
  )

[scatter1;scatter2] |> Chart.Plot |> Chart.Show
