#r "System.Runtime.Numerics.dll"

open System.Numerics
open Checked

//{\displaystyle (m^{e})^{d}\equiv m{\pmod {n}}}
// https://en.wikipedia.org/wiki/Fermat%27s_little_theorem
// a^p = a      (mod p)
// if p is prime

type IsPrime =
  | Maybe
  | No


let isPrime (smallP :int) : IsPrime = 
  let flt a p =  
    let result : bigint = BigInteger.ModPow(a,p,p)
    result = a % p    

  let p : bigint = bigint(smallP)
  let a1 : bigint = BigInteger.Parse("123456789") // Random number 1
  let a2 : bigint = BigInteger.Parse("987654321") // Random number 2

  if flt a1 p && flt a2 p then Maybe
  else No

// seq{1000000..1010000}
// |> Seq.filter(fun i -> (isPrime i ) = No)
// |> Seq.iter (printfn "%d is maybe prime")


// 85
// isPrime(85) // ?? Wrong




// Euler's theorem
// https://en.wikipedia.org/wiki/Euler%27s_theorem

// RSA
// https://en.wikipedia.org/wiki/RSA_(cryptosystem)
// (m^e)^d = m % n

// p & q -> primes
// n = pq


// (p-1)(1-1) ??

// x ^ a ^ b      mod n

3.0 ** 4.0
(3.0 ** 2.0 % mod ** 2.0

let pow (a: int) (b: int) = 
  match b with 
  | 0 -> 1
  | _ -> 
    seq{0..b-2} 
    |> Seq.fold (fun acc i -> acc * a) a

(pow 6 5) % 50
pow ((pow 6 3) % 50) 2 % 50
