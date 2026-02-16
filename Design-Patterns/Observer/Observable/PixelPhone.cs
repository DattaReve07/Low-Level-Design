using Observer.ObserverEntity;

namespace Observer.Observable;

public class PixelPhone : IStock
{
    private readonly List<Customer> customers = [];
    private const string ItemName = "Pixel Phone";
    private double stockCount;

    public void Add(Customer customer)
    {
        customers.Add(customer);
    }

    public void Remove(Customer customer)
    {
        customers.Remove(customer);
    }

    public void Notify()
    {
        foreach (var customer in customers)
        {
            customer.update();
        }
    }

    public double getCount()
    {
        return stockCount;
    }

    public void setCount(double newCount)
    {
        if(stockCount == 0 && newCount > 0)
        {
            stockCount = newCount;
            Notify();
        }
        else
        {
            stockCount = newCount;
        }
    }

    public string getName()
    {
        return ItemName;
    }
}