#r "nuget: XPlot.Plotly"

open XPlot.Plotly
open System.Numerics
open System

#load "./modules/Helpers.fsx"
open Helpers

#load "./modules/GraphComplexFunction.fsx"
open GraphComplexFunction

let s =
  Complex(1.5, 0.0)
  |> initInfinite (fun c ->  c * Complex(Math.Cos(PI / 32.0), Math.Sin( PI / 32.0)))
  |> Seq.take 65

let fn (s : Complex) : Complex = s ** s

graphFns fn s
