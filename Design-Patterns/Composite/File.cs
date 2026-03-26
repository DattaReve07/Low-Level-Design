namespace Composite;

public class File(string name) : FileSystemComponent
{
    public void printContents()
    {
        Console.WriteLine("This is a file: " + name);
    }
}