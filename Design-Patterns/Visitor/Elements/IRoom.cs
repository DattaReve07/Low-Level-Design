using Visitor.Visitor;

namespace Visitor.Elements;

public interface IRoom
{
    void Accept(IVisitor visitor);
    public int GetRoomNumber();
}