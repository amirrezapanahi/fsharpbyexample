open System

let name = "John"

// String interpolation is prefixed with `$`
// values that you want to inject in the string are templated with curly braces `{}`
let a = $"Hello, {name}"

// Anything inside the `{}` can be treated as a valid expression
// This means you can do more expressive stuff inside
let b =
    $"""Hello, 
    {if name <> "John" then name else "[redacted]"}"""

printfn "%s" a
printfn "%s" b

// Note: If you want to reference string literals within string interpolation
// expression you should wrap the whole string with triple quotation marks
