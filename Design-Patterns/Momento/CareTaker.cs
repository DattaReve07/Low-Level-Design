namespace Momento;

public class CareTaker
{
    private readonly Stack<Memento> history = new();

    public void Save(Memento memento)
    {
        history.Push(memento);
    }
    public void Undo(Originator originator)
    {
        history.Pop();
        if (history.Count <= 0)
        {
            Console.WriteLine("=========== Nothing to undo");
            return;
        };
        originator.setContent(history.Peek().getContent());
    }

}