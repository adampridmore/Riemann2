// #r "nuget: FSharp.Charting, 2.1.0"

// printfn "Hello"

// let x = 
//   [1..10]
//   |> Seq.sum

// printfn "%d" x


let f n s = 1.0 / (n ** s) 

let z s = 
  let iterations = 100
  
  [1..iterations]
  |> Seq.map float
  |> Seq.map (fun n -> f n s)
  |> Seq.sum

z (2.0)
z (3.0)
printfn "%A" (z (-1.0))
