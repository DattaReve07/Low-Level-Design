namespace Decorator;

/// <summary>
/// The 'Decorator' abstract class
/// </summary>
public abstract class Decorator(LibraryItem libraryItem) : LibraryItem
{
    public override void Display() => libraryItem.Display();

}