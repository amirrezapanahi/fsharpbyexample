open System

// Strings are enclosed in double quotation marks (`"`)
let a = "This is a string"

// You can use [escape sequences](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/strings) within a string, here we use a new line
let b = "This is a string \nIt's cool eh?"

// You can create multi-line strings with triple quotation marks
let c =
    """
    This is a multi-line string
    1
    2
    3
    4
    """

// F# gives us format specifiers similar to languages like C which specify the type of the data you wish you display
// Here `%s` is saying "I want to put a string here"
printfn "%s" a
printfn "%s" b
printfn "%s" c
