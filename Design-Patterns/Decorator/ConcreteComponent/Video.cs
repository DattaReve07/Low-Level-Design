namespace Decorator;


/// <summary>
/// The 'ConcreteComponent' class
/// </summary>
public class Video : LibraryItem
{
    private readonly string director;
    private readonly string title;
    private readonly int playTime;

    // Constructor
    public Video(string director, string title,
        int numCopies, int playTime)
    {
        this.director = director;
        this.title = title;
        NumCopies = numCopies;
        this.playTime = playTime;
    }

    public override void Display()
    {
        Console.WriteLine("\nVideo ----- ");
        Console.WriteLine($" Director: {director}");
        Console.WriteLine($" Title: {title}");
        Console.WriteLine($" Playtime: {playTime}");
        Console.WriteLine($" # Available videos to borrow: {NumCopies}\n");
    }
}