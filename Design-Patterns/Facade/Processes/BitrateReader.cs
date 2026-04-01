namespace Facade;

public class BitrateReader
{
    public void ReadBitrate()
    {
        Console.WriteLine("Reading Bitrate...");
    }

    public void Convert(VideoFile file, Codec codec)
    {
        Console.WriteLine($"Converting bitrate for {file.Name}... with codec {codec.GetCodec()}");
    }
}