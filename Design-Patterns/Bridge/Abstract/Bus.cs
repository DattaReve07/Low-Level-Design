using Bridge.Implementation;

namespace Bridge.Abstract;

public class Bus(IWorkshop workshop1, IWorkshop workshop2) : Vehicle(workshop1, workshop2)
{
    public override void Manufacture()
    {
        Console.Write("Bus ");
        workshop1.Work();
        Console.Write (" And ");
        workshop2.Work();
    }
}