// See https://aka.ms/new-console-template for more information

using Prototype;

Console.WriteLine("================== Prototype Design Pattern ================");

var dragon = new UniTree(1, "Dragon", "A mythical creature that breathes fire.", 4, 2);
dragon.printDetails();
var dragonProtype = dragon.Clone();
dragonProtype.printDetails();
