// See https://aka.ms/new-console-template for more information

using Bridge.Abstract;
using Bridge.Implementation;

Console.WriteLine("================== Bridge Design Pattern ==================");

var car = new Car(new Produce(), new Assemble());
var bus = new Bus(new Produce(), new Assemble());

car.Manufacture();
bus.Manufacture();