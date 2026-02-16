using Observer.ObserverEntity;

namespace Observer.Observable;

public interface IStock
{
    public void Add(Customer customer);

    public void Remove(Customer customer);

    public void Notify();
    public double getCount();
    public void setCount(double newCount);
    string getName();
}