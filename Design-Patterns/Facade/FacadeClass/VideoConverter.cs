namespace Facade;

public class VideoConverter
{
    public VideoFile Convert(string filename, string format)
    {
        Console.WriteLine($"Converting {filename} to {format} format...");
        var file = new VideoFile(filename, format);
        var codecFactory = new CodecFactory();
        var bitrateReader = new BitrateReader();
        var fileCodec = codecFactory.Extract(format);
        bitrateReader.Convert(file, fileCodec);
        var result = new AudioMixer().Fix(file);
        Console.WriteLine("Conversion completed.");
        return result;
    }
}