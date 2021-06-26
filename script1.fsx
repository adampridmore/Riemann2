// #r "nuget: FSharp.Charting, 2.1.0"

// printfn "Hello"

// let x = 
//   [1..10]
//   |> Seq.sum

// printfn "%d" x


let f n s = 1.0 / (n ** s) 

let zseq s : seq<float> = 
  let iterations = 100
  
  [1..iterations]
  |> Seq.map float
  |> Seq.map (fun n -> f n s)


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

// printfunction zseq 1.0

printfunction zagg 8.0



