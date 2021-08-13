#r "System.Runtime.Numerics.dll"

open System.Numerics

let p = 5
let q = bigint(7)
let n = bigint(p) * q


// Fermat's little theorem
// https://en.wikipedia.org/wiki/Fermat%27s_little_theorem
// a^p = a (mod p)
let fn (a : bigint) : bigint = 
  let x : bigint = BigInteger.Pow(a,p)
  BigInteger.(%) (x, bigint(p))
  // BigInteger.ModPow(BigInteger, BigInteger, BigInteger) 

// fn 3 

// Euler's theorem
// https://en.wikipedia.org/wiki/Euler%27s_theorem

// RSA

// (p-1)(1-1) ??



// let p = 3
// let a : bigint = bigint(123456678)

// // a^p = a (mod p)
// let x : bigint = BigInteger.Pow(a,p)
// let result : bigint = BigInteger.(%) (x, bigint(p))

// result = a





// let isPrime(p: int) : bool = 
//   let a : bigint = bigint(123456678)

//   // a^p = a (mod p)
//   let x : bigint = BigInteger.Pow(a,p)
//   let result : bigint = BigInteger.(%) (x, bigint(p))

//   result = a

// isPrime (3)



let isPrime (smallP :int) : bool = 
 
  //fermat's little theorem
  // https://en.wikipedia.org/wiki/Fermat%27s_little_theorem
  // a^p = a (mod p)
  // if p is prime
  let flt a p =  
    let result : bigint = BigInteger.ModPow(a,p,p)
    result = a % p    

  let p : bigint = bigint(smallP)
  let a1 : bigint = BigInteger.Parse("123456789") // Random number 1
  let a2 : bigint = BigInteger.Parse("987654321") // Random number 2

  flt a1 p && flt a2 p

seq{1000000..1010000}
|> Seq.filter(isPrime)
|> Seq.iter (printfn "%d")


isPrime(85) // ?? Wrong


