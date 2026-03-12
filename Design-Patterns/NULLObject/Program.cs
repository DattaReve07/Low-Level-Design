// See https://aka.ms/new-console-template for more information

using NULLObject;

Console.WriteLine("Null Object Design Pattern");

Vehicle vehicle = VehicleFactory.getVehicle("Car");
Console.WriteLine("Seating Capacity: " + vehicle.getSeatingCapacity());
Console.WriteLine("Fuel Capacity: " + vehicle.getFuelCapacity());

Console.WriteLine("================================");

Vehicle nullVehicle = VehicleFactory.getVehicle("Bus");
Console.WriteLine("Seating Capacity: " + nullVehicle.getSeatingCapacity());
Console.WriteLine("Fuel Capacity: " + nullVehicle.getFuelCapacity());