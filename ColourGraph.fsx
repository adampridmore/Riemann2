#r "nuget: XPlot.Plotly"

open XPlot.Plotly
open System.Numerics



let toPlotPoints (cseq: seq<Complex>) = 
  cseq |> Seq.map (fun x -> x.Real, x.Imaginary )

let s = [
  Complex(1.0, 2.0);
  Complex(2.0, 1.0)
]

let points1 = ([
                  Complex(1.0, 2.0);
                  Complex(2.0, 1.0)
              ])
              |> toPlotPoints |> Seq.toList |> List.unzip

let points2 = [1.0;2.0], [3.0;4.0]

let scatter1 =
  Scatter(
      x = (points1 |> fst),
      y = (points1 |> snd)
  )

let scatter2 =
  Scatter(
      x = (points2 |> fst),
      y = (points2 |> snd)
  )

[scatter1;scatter2] |> Chart.Plot |> Chart.Show

// line2 |> Chart.Show

// [line1;line2] |> Chart.Show
