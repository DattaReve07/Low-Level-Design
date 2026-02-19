namespace AbstractFactory;

public class Punch : Car
{
    public void getCarInfo()
    {
        Console.WriteLine("Car Info:");
        Console.WriteLine("Model: Tata Punch");
        Console.WriteLine("Type: Compact SUV\n");
    }
}