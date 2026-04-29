// See https://aka.ms/new-console-template for more information

using Visitor.Elements;
using Visitor.Visitor;

Console.WriteLine("======================= Visitor Design Pattern ===========================");
Console.WriteLine("======================= Hotel Room Management ===========================");


var rooms = new List<IRoom>
{
    new StandardRoom(101),
    new SuiteRoom(201, 3),
    new DeluxeRoom(301, true),
    new StandardRoom(401),
    new SuiteRoom(501, 3),
    new DeluxeRoom(601, false)
};

var houseKeeper = new HouseKeeping();
var pricingVisitor = new PricingVisitor();

Console.WriteLine("\n--- Housekeeping Visitor ---");
foreach (var room in rooms)
{
    room.Accept(houseKeeper);
}


var roomService = new RoomService("Dinner");
var roomNumbersToService = new HashSet<int> { 201, 301, 501 };

Console.WriteLine("\n--- Room Service Visitor ---");
foreach (var room in rooms)
{
    if (roomNumbersToService.Contains(room.GetRoomNumber()))
    {
        room.Accept(roomService);
    }
}

Console.WriteLine("\n--- Pricing Visitor ---");
foreach (var room in rooms)
{
    room.Accept(pricingVisitor);
}
