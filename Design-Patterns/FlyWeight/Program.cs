// See https://aka.ms/new-console-template for more information

using FlyWeight;

Console.WriteLine("============================ FlyWeight Factory Pattern ====================================");

List<Drone> drones = [];

var droneType1 = DroneFactory.GetDroneType(DroneTypesEnum.Surveillance, "Surveillance", "Grey");
var droneType2 = DroneFactory.GetDroneType(DroneTypesEnum.Delivery, "Delivery", "White");
var droneType3 = DroneFactory.GetDroneType(DroneTypesEnum.Kamikaze, "Kamikaze", "Black");
var droneType4 = DroneFactory.GetDroneType(DroneTypesEnum.Interceptor, "Interceptor", "Red");

drones.Add(new Drone(droneType1, 10, 20));
drones.Add(new Drone(droneType1, 15, 25));
drones.Add(new Drone(droneType2, 30, 40));
drones.Add(new Drone(droneType2, 35, 45));
drones.Add(new Drone(droneType3, 50, 60));
drones.Add(new Drone(droneType3, 55, 65));
drones.Add(new Drone(droneType4, 70, 80));
drones.Add(new Drone(droneType4, 75, 85));

drones.ForEach(drone => drone.Draw());