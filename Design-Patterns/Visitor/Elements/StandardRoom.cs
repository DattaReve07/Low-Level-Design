using Visitor.Visitor;

namespace Visitor.Elements;

public class StandardRoom(int roomNumber) : IRoom
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitStandardRoom(this);
    }

    public int GetRoomNumber()
    {
        return roomNumber;
    }
}