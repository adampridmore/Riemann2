// #r "nuget: FSharp.Charting, 2.1.0"

#r "nuget: XPlot.Plotly, 4.0.3"

// printfn "Hello"

// let x = 
//   [1..10]
//   |> Seq.sum

// printfn "%d" x


let f n s = 1.0 / (n ** s) 

let iterations = 100

let zseq s : seq<float> = 
  [1..iterations]
  |> Seq.map (float >> fun n -> f n s)

let zagg (s : float) : (seq<float>) = 
  s
  |> zseq
  |> Seq.scan (fun (state : float) x -> (x + state)) (0.0)
  
let z s : float = 
   zseq s |> Seq.sum



let printfunction fn s = 
  s 
  |> fn
  |> Seq.iteri(fun i x -> printfn "%d : %A" i x)

//printfunction zseq 2.0

printfunction zagg 2.0

(System.Math.PI ** 2.0) / 6.0

// open XPlot.Plotly

// let results = zagg 2.0
// results |> Chart.Line |> Chart.Show
