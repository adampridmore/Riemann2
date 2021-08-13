#r "System.Runtime.Numerics.dll"

open System.Numerics

//fermat's little theorem
// https://en.wikipedia.org/wiki/Fermat%27s_little_theorem
// a^p = a (mod p)
// if p is prime
let isPrime (smallP :int) : bool = 
  let flt a p =  
    let result : bigint = BigInteger.ModPow(a,p,p)
    result = a % p    

  let p : bigint = bigint(smallP)
  let a1 : bigint = BigInteger.Parse("123456789") // Random number 1
  let a2 : bigint = BigInteger.Parse("987654321") // Random number 2

  flt a1 p && flt a2 p





// Euler's theorem
// https://en.wikipedia.org/wiki/Euler%27s_theorem

// RSA

// (p-1)(1-1) ??











seq{1000000..1010000}
|> Seq.filter(isPrime)
|> Seq.iter (printfn "%d")


isPrime(85) // ?? Wrong





