namespace NULLObject;

public class Car : Vehicle
{
    public Car()
    {
        Console.WriteLine("Car object created");
    }
    public int getSeatingCapacity()
    {
        return 40;
    }

    public int getFuelCapacity()
    {
        return 10;
    }
}