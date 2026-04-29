using Visitor.Elements;

namespace Visitor.Visitor;

public class PricingVisitor : IVisitor
{
    private int totalRevenue;
    private const int SingleRoomPrice = 100;
    private const int SuiteRoomPrice = 200;
    private const int DeluxeRoomPrice = 300;
    private const int JacuzziRoomPrice = 400;
    public void VisitStandardRoom(StandardRoom room)
    {
        totalRevenue += SingleRoomPrice;
        Console.WriteLine($"Standard Room {room.GetRoomNumber()} added to revenue. Current total: {totalRevenue}");
    }

    public void VisitSuiteRoom(SuiteRoom room)
    {
        totalRevenue += SuiteRoomPrice * room.GetNoOfRooms();
        Console.WriteLine($"Suite Room {room.GetRoomNumber()} with {room.GetNoOfRooms()} rooms added to revenue. Current total: {totalRevenue}");
    }

    public void VisitDeluxeRoom(DeluxeRoom room)
    {
        totalRevenue += room.HasJacuzzi() ? JacuzziRoomPrice : DeluxeRoomPrice;
        Console.WriteLine($"Deluxe Room {room.GetRoomNumber()} {(room.HasJacuzzi() ? "with jacuzzi" : "without jacuzzi")} added to revenue. Current total: {totalRevenue}");
    }

}