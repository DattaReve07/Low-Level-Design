namespace Iterator;

public class Library(List<Book> books) : Aggregator
{
    public Iterator GetIterator()
    {
        return new BookIterator(books);
    }
}