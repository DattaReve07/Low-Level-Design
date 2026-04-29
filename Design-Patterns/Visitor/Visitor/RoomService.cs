using Visitor.Elements;

namespace Visitor.Visitor;

public class RoomService(string orderDetails) : IVisitor
{
    public void VisitStandardRoom(StandardRoom room)
    {
        Console.WriteLine($"Room service delivering {orderDetails} to standard room {room.GetRoomNumber()}");
    }

    public void VisitSuiteRoom(SuiteRoom room)
    {
        Console.WriteLine($"Room service delivering {orderDetails} to suite room {room.GetRoomNumber()} with {room.GetNoOfRooms()} rooms");
    }

    public void VisitDeluxeRoom(DeluxeRoom room)
    {
        Console.WriteLine($"Room service delivering {orderDetails} to deluxe room {room.GetRoomNumber()} {(room.HasJacuzzi() ? "including jacuzzi" : "without jacuzzi")}");
    }
}