namespace Decorator;

using static System.Console;

/// <summary>
/// Decorator Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create book
        var book = new Book("Worley", "Inside ASP.NET", 10);
        book.Display();

        // Create video
        var video = new Video("Spielberg", "Jaws", 23, 92);
        video.Display();

        // Make video borrowable, then borrow and display
        Console.WriteLine("\nMaking video borrowable:");

        var catalog = new Catalog(video);
        catalog.BorrowItem("Customer #1");
        catalog.BorrowItem("Customer #2");

        catalog.Display();

        // Make book borrowable, then borrow and display
        Console.WriteLine("\nMaking book borrowable:");

        var catalog2 = new Catalog(book);
        catalog2.BorrowItem("Customer #3");
        catalog2.Display();

    }
}
