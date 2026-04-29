using Visitor.Visitor;

namespace Visitor.Elements;

public class SuiteRoom(int roomNumber, int noOfRooms) : IRoom
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitSuiteRoom(this);
    }

    public int GetRoomNumber()
    {
        return roomNumber;
    }

    public int GetNoOfRooms()
    {
        return noOfRooms;
    }
}