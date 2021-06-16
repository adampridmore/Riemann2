// #r "nuget: FSharp.Charting, 2.1.0"

printfn "Hello"

let x = 
  [1..10]
  |> Seq.sum

printfn "%d" x


let f n s = 1.0 / (n ** s) 

let z s = 
  [1..100]
  |> Seq.map float
  |> Seq.map (fun n -> f n s)
  |> Seq.sum

// f 1.0 2

z (2.0)
