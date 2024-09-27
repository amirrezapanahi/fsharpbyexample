// A discriminated union is a type that can be one of several named cases
// Each case can optionally have associated data

type Animal =
    //
    | Dog of name: string
    // The Dog has a single string value (name)
    | Cat of name: string * lives: int
// The Cat has two values: a string (name) and an int (lives)

// Pattern matching allows us to *enforce* handling all possible cases of the union
let describe animal =
    match animal with
    // For each case, we can destructure and use the associated data
    | Dog name -> sprintf "%s says Woof!" name
    | Cat(name, _) -> sprintf "%s says Meow!" name

let dog = Dog "Buddy"
let cat = Cat("Whiskers", 9)

// Process and print information about each animal
// This demonstrates how we can work with a collection of mixed animal types
for animal in [ dog; cat ] do
    printfn "%s" (describe animal)
