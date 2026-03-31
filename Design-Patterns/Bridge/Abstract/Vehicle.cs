using Bridge.Implementation;

namespace Bridge.Abstract;

public abstract class Vehicle(IWorkshop workshop1, IWorkshop workshop2)
{
    private IWorkshop workshop1 = workshop1;
    private IWorkshop workshop2 = workshop2;

    public abstract void Manufacture();
}