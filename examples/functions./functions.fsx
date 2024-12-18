open System

// Functions are created with the `let` keyword. Parameters for functions are curried and are implicitly typed by the compiler.
// The last expression in a function will be the returned value
let add a b = a + b

// You can also explicitly set the types for your parameters
let multiply (a: int) (b: float) = float a * b

printfn $"{add 1 2}"
printfn $"{multiply 2 3.2}"
