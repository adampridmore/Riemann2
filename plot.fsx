#r "nuget: XPlot.Plotly"

open XPlot.Plotly
open System.Numerics

//[ 1 .. 10 ] |> Chart.Line |> Chart.Show

let s = [
  Complex(1.0, 2.0);
  Complex(2.0, 1.0)
]

let toPlotPoints (cseq: seq<Complex>) =  cseq |> Seq.map (fun x -> x.Real, x.Imaginary )

//let trace1 = [(1.0, 2.0); (2.0, 1.0)]

s |> toPlotPoints |> Chart.Line |> Chart.Show

// let trace1 =
//     Scatter(
//         x = [1; 2; 3; 4],
//         y = [10; 15; 13; 17]
//     )


// trace1
// |> Chart.Plot
// |> Chart.WithWidth 700
// |> Chart.WithHeight 500
// |> Chart.Show



// let rnd = new System.Random() 
// let next() = rnd.NextDouble() * rnd.NextDouble()
// let points = [ for i in 0 .. 1000 -> next(), next() ]

// points |> Chart.Scatter |> Chart.Show
