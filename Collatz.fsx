#r "nuget: XPlot.Plotly"

open XPlot.Plotly


let next n = 
  match n with
  | n when n % 2 = 0 -> n / 2
  | n -> (n * 3) + 1


let collatz x = 
  Seq.unfold (fun n -> 
  if n = 1 then None 
  else
    Some(n, next n)
  ) x


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
