using Observer.Observable;

namespace Observer.ObserverEntity;

public class Customer(IStock stock)
{
    public void update()
    {
        Console.WriteLine($"{stock.getCount()} units of {stock.getName()} are available");
    }
}