using Visitor.Visitor;

namespace Visitor.Elements;

public class DeluxeRoom(int roomNumber, bool hasJacuzzi ) : IRoom
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitDeluxeRoom(this);
    }

    public int GetRoomNumber()
    {
        return roomNumber;
    }

    public bool HasJacuzzi()
    {
        return hasJacuzzi;
    }
}