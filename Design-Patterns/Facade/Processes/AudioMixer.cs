namespace Facade;

public class AudioMixer
{
    public VideoFile Fix(VideoFile file)
    {
        Console.WriteLine($"Fixing audio file: {file.Name}");
        return file;
    }
}