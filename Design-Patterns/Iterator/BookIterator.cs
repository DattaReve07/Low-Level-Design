namespace Iterator;

public class BookIterator(List<Book> books) : Iterator
{
    private int index;

    public bool HasNext()
    {
        return index < books.Count;
    }

    public object Next()
    {
        return HasNext() ? books[index++] : throw new InvalidOperationException("No more books.");
    }
}