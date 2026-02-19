namespace AbstractFactory;

public class IndianCarFactory : CarFactory
{
    public Car CreateCar()
    {
        Console.WriteLine("Creating an Indian car...");
        return new Punch();
    }
}