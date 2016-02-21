open LegoCommands
open Lego.Ev3.Core
open Lego.Ev3.Desktop

[<EntryPoint>]
let main argv =
    let brick = Brick(UsbCommunication())
    brick |> connectAsync |> Async.RunSynchronously |> ignore
    brick |> moveAsync    |> Async.RunSynchronously |> ignore
    brick |> speakAsync   |> Async.RunSynchronously |> ignore

    0 // return an integer exit code