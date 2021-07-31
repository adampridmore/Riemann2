open Checked

#load "./modules/Helpers.fsx"
open Helpers

#r "nuget: XPlot.Plotly"
open XPlot.Plotly

open FSharp.Collections.Array.Parallel

type ctype = uint64

let next (n: ctype) = 
  match n with
  | n when n % 2UL = 0UL -> n / 2UL
  | n -> (n * 3UL) + 1UL


let collatz (x: ctype) = 
  Seq.append [x] (Seq.unfold (fun n -> 
    match n with
    | 1UL -> None
    | n -> let n1 = n |> next
           Some(n1,n1)
  ) x)
  
 
// let result =
//   collatz 113383UL
//   |> Seq.mapi(fun i  n -> (i, n))
//   |> Seq.toList
//   |> List.unzip

// let trace1 =
//     Scatter(
//         x = (result |> fst),
//         y = (result |> snd)
//     )

// trace1
// |> Chart.Plot
// |> Chart.WithTitle "Collatz"
// |> Chart.WithXTitle "Iteration"
// |> Chart.WithYTitle "Value"
// |> Chart.WithWidth 1800
// |> Chart.WithHeight 1000
// |> Chart.Show




let getLength n = 
  let length = (collatz n) |> Seq.length
  printfn "%d - %d" n length
  (n,length)

#time "on"

let collatzLength = 
  seq{1UL..1000000UL} |> Seq.toArray
  |> Array.map getLength
  |> Array.unzip
  

let trace2 =
    Scatter(
        x = (collatzLength |> fst),
        y = (collatzLength |> snd)
    )

trace2
|> Chart.Plot
|> Chart.WithTitle "Collatz"
|> Chart.WithXTitle "Iteration"
|> Chart.WithYTitle "Value"
|> Chart.WithWidth 1800
|> Chart.WithHeight 1000
|> Chart.Show

