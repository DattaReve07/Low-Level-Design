namespace Composite;

public class Directory(string path) : FileSystemComponent
{
    private readonly List<FileSystemComponent> components = [];

    public void Add(FileSystemComponent component)
    {
        components.Add(component);
    }

    public void printContents()
    {
        Console.WriteLine("This is a directory: " + path);
        foreach (var component in components)
        {
            component.printContents();
        }
    }
}