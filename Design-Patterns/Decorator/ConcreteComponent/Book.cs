namespace Decorator;

/// <summary>
/// The 'ConcreteComponent' class
/// </summary>
public class Book : LibraryItem
{
    private readonly string author;
    private readonly string title;

    // Constructor
    public Book(string author, string title, int numCopies)
    {
        this.author = author;
        this.title = title;
        NumCopies = numCopies;
    }

    public override void Display()
    {
        Console.WriteLine("\nBook ------ ");
        Console.WriteLine($" Author: {author}");
        Console.WriteLine($" Title: {title}");
        Console.WriteLine($" # Available books to borrow: {NumCopies}\n");
    }
}
