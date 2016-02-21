module LegoCommands

open Lego.Ev3.Core
open Lego.Ev3.Desktop
open System.Threading.Tasks
open Arguments

let awaitTask (task: Task) = task |> Async.AwaitIAsyncResult
                                  |> Async.Ignore
let connectAsync (brick:Brick) = async {
    do! brick.ConnectAsync() |> awaitTask }

let moveAsync (brick:Brick) = async {
    do! brick.DirectCommand.TurnMotorAtPowerForTimeAsync(motors, power, uint32 duration, breakEnabled) |> awaitTask }

let speakAsync (brick:Brick) = async {
    do! brick.DirectCommand.PlayToneAsync(volume, frequency, duration) |> awaitTask }