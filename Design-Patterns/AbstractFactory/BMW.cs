namespace AbstractFactory;

public class BMW : Car
{
    public void getCarInfo()
    {
        Console.WriteLine("Car Info:");
        Console.WriteLine("Model: BMW X5");
        Console.WriteLine("Type: Luxury SUV\n");
    }
}