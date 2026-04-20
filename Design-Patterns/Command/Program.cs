// See https://aka.ms/new-console-template for more information
using Command.Command;
using Command.Invoker;
using Command.Receiver;

Console.WriteLine("============================= Command Design Pattern ==================================");

var airConditioner = new AirConditioner();
var turnOnAcCommand = new TurnOnAcCommand(airConditioner);
var turnOffAcCommand = new TurnOffAcCommand(airConditioner);

var acRemote = new Remote();
acRemote.SetCommand(turnOnAcCommand);
acRemote.OkButton();

acRemote.SetCommand(turnOffAcCommand);
acRemote.OkButton();

acRemote.BackButton();
acRemote.BackButton();