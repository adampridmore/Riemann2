#r "nuget: XPlot.Plotly"

open System.Numerics
open XPlot.Plotly


// let a = Complex(1.0,2.0)


// let fn x = x * Complex.ImaginaryOne

// fn a

// a + a

open System
let PI = Math.PI

// Rotate PI/4
Complex(1.0, 0.0)
|> Seq.unfold(fun c -> Some(c, c * Complex(Math.Cos(PI / 4.0), Math.Sin( PI / 4.0)) ))
|> Seq.take 8
|> Seq.map(fun c -> c, sprintf "%0.3f+%0.3fi" c.Real c.Imaginary )
|> Seq.mapi(fun i (c, txt) -> printfn "%d - %s" i txt; (c.Real, c.Imaginary))
|> Chart.Scatter |> Chart.WithOptions() |> Chart.Show
