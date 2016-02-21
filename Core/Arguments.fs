module Arguments
open Lego.Ev3.Core

let volume = 50
let frequency = uint16 3000
let duration = uint16 333
let power = 100
let motors = OutputPort.B ||| OutputPort.C
let breakEnabled = false