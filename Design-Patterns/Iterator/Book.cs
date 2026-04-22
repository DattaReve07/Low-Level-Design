namespace Iterator;

public class Book(string title, string author, decimal price)
{
    private string Title { get; } = title;
    private string Author { get; } = author;
    private decimal Price { get; } = price;

    public override string ToString()
    {
        return $"{Title} by {Author}, priced at ₹{Price}";
    }
}