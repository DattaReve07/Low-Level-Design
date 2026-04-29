using Visitor.Elements;

namespace Visitor.Visitor;

public class HouseKeeping : IVisitor
{
    public void VisitStandardRoom(StandardRoom room)
    {
        Console.WriteLine($"Cleaning Standard Room {room.GetRoomNumber()}");
    }

    public void VisitSuiteRoom(SuiteRoom room)
    {
        Console.WriteLine($"Cleaning Suite Room {room.GetRoomNumber()} with {room.GetNoOfRooms()} rooms");
    }

    public void VisitDeluxeRoom(DeluxeRoom room)
    {
        Console.WriteLine($"Cleaning Deluxe Room {room.GetRoomNumber()} {(room.HasJacuzzi() ? "including jacuzzi" : "without jacuzzi")}");
    }
}