#r "nuget: XPlot.Plotly"

open XPlot.Plotly

let next n = 
  match n with
  | n when n % 2 = 0 -> n / 2
  | n -> (n * 3) + 1


let collatz x = 
  Seq.append [x] (Seq.unfold (fun n -> 
    match n with
    | 1 -> None
    | n -> let n1 = n |> next
           Some(n1,n1)
  ) x)
  
let results  = 
  collatz 27
  |> Seq.mapi(fun i  n -> (i, n))
  |> Seq.toList
  |> List.unzip

let trace1 =
    Scatter(
        x = (results |> fst),
        y = (results |> snd)
    )

trace1
|> Chart.Plot
|> Chart.WithTitle "Collatz"
|> Chart.WithXTitle "Iteration"
|> Chart.WithYTitle "Value"
|> Chart.WithWidth 1800
|> Chart.WithHeight 1000
|> Chart.Show
