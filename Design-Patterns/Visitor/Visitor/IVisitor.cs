using Visitor.Elements;

namespace Visitor.Visitor;

public interface IVisitor
{
    void VisitStandardRoom(StandardRoom room);
    void VisitSuiteRoom(SuiteRoom room);
    void VisitDeluxeRoom(DeluxeRoom room);
}