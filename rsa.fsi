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



let isPrime (p :int) : bool = 
  // let p = 8
  let a : bigint = bigint(123)
  //let a = 10

  // a^p = a (mod p)
  // let x = pown a p
  let x = BigInteger.Pow(a,p)
  // let result  = x % p
  let result  = BigInteger.(%) (x, bigint(p))

  result = a % (bigint(p))

seq{1..100}
|> Seq.filter(isPrime)
|> Seq.iter (printfn "%d")


isPrime(85) // ?? Wrong




// let i = new BigInteger(10)
// let i2 = new bigint(20)

// BigInteger.Pow(bigint(123), 2)

// BigInteger.(%) ((bigint(105)), (bigint(20)))
