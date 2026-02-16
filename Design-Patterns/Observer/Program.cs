// See https://aka.ms/new-console-template for more information

using Observer.Observable;
using Observer.ObserverEntity;

Console.WriteLine("Lets see how Observer pattern works!");

IStock pixelPhone = new PixelPhone();
var customer1 = new Customer(pixelPhone);
var customer2 = new Customer(pixelPhone);

pixelPhone.Add(customer1);
pixelPhone.Add(customer2);

pixelPhone.setCount(0);
Console.WriteLine("Stock count is 0, no notification should be sent");

Console.WriteLine("================================");

pixelPhone.setCount(10);
Console.WriteLine("Stock count is 10, notification should be sent to both customers");
Console.WriteLine("================================");

pixelPhone.Remove(customer1);
pixelPhone.setCount(20);
Console.WriteLine("Stock count is 20, no notification should be sent because count was not 0");
Console.WriteLine("================================");


pixelPhone.setCount(0);
Console.WriteLine("Stock count set to 0");

pixelPhone.setCount(5);
Console.WriteLine("Stock count is 5, notification should be sent to customer2 only because customer1 was removed");
Console.WriteLine("================================");
