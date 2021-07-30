open System.Numerics

let iterations = 100

let zetaSeq (s: Complex) : seq<Complex> = 
  [1..iterations]
  |> Seq.map(fun n ->
    Complex.One / (Complex(n |> float, 0.0) ** s)
  )
  
let zeta (s: Complex) : Complex = 
  zetaSeq s 
  |> Seq.fold ( + ) Complex.Zero

let zetaSeqCumulative (s : Complex) : (seq<Complex>) = 
  s
  |> zetaSeq
  |> Seq.scan (fun (state : Complex) x -> (x + state)) (Complex.Zero)
  |> Seq.skip 1
