namespace Decorator;

/// <summary>
/// The 'Component' abstract class
/// </summary>
public abstract class LibraryItem
{
    // Each T has its own NumCopies
    public int NumCopies { get; set; }

    public abstract void Display();
}