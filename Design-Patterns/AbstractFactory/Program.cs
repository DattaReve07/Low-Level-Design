// See https://aka.ms/new-console-template for more information
using AbstractFactory;


Console.WriteLine("Abstarct Factory Design Pattern Example..\n");

CarFactory carFactory = new GermanCarFactory();
Car car = carFactory.CreateCar();
car.getCarInfo();


carFactory = new IndianCarFactory();
car = carFactory.CreateCar();
car.getCarInfo();
