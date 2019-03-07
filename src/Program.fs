////// 2019-03-07

// val x: int
let x = 1

// val g: string
let g =
  "hello world"

// val boolean: bool
let boolean =
  true

// val fp: float
let fp =
  0.1

// val x: int
let x2 =
  1 + 2

let y =
  float 1 + 4.2

// val f: int -> int
let f1 = function x -> let y = 1
                       let z = 2
                       x / y * z

// val f2: int -> int
let f2 x = x + 1

// if then else
let f3 n =
  if n > 0 then 1
  else 0

// How to get two arguments?
// val f4: int  -> int -> int
let f4 a b =
  a + b

// val f: string [] -> int
[<EntryPoint>]
let main _ =
  // Simplest form of an expression = a value
  printfn "hello world"
  0
