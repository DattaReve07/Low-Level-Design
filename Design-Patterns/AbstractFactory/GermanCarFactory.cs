namespace AbstractFactory;

public class GermanCarFactory : CarFactory
{
    public Car CreateCar()
    {
        Console.WriteLine("Creating a German car...");
        return new BMW();
    }
}