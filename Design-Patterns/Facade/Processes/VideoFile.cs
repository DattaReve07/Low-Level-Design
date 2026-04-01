namespace Facade;

public class VideoFile(string name, string codec)
{
    public string Name { get; set; } = name;
    public string Codec { get; set; } = codec;

    public void Save()
    {
        Console.WriteLine("Saving video file...");
    }
}