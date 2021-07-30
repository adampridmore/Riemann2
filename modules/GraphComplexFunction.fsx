#r "nuget: XPlot.Plotly"

open XPlot.Plotly
open System.Numerics
open System

let graphFns (fn : Complex -> Complex) (s : seq<Complex>) : Unit =

  let toPlotPoints (cseq: seq<Complex>) = 
    cseq 
    |> Seq.map (fun x -> x.Real, x.Imaginary )
    |> Seq.toList
    |> List.unzip

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

  ()
