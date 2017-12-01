[<RequireQualifiedAccess>]
module Encode

open Renderer
open Docs.Helpers

open Fulma.Elements
open Fable.Helpers.React

let private content =
    """
# Encode

Module for turning F# values into Json values.

*This mobule is inspired by [Json.Encode from Elm](http://package.elm-lang.org/packages/elm-lang/core/latest/Json-Encode).*

## How to use it ?

```fsharp
    open Thot.Json.Encode

    let person =
        object
            [ "firstname", string "maxime"
              "surname", string "mangel"
              "age", int 25
              "address", object
                            [ "street", string "main street"
                              "city", string "Bordeaux" ]
            ]

    let compact = encode 0 person
    // {"firstname":"maxime","surname":"mangel","age":25,"address":{"street":"main street","city":"Bordeaux"}}

    let readable = encode 4 person
    // {
    //     "firstname": "maxime",
    //     "surname": "mangel",
    //     "age": 25,
    //     "address": {
    //         "street": "main street",
    //         "city": "Bordeaux"
    //     }
    // }
```
    """.Trim()

let body =
    Content.content [ ]
        [ br [ ]
          htmlFromMarkdown content ]

let render () =
    Page.render {
        Page = Route.Encode
        Title = None
        Body = body |> parseReactStatic
    }
