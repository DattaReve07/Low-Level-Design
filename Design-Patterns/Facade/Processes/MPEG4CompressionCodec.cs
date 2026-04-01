namespace Facade;

public class MPEG4CompressionCodec : Codec
{
    public MPEG4CompressionCodec()
    {
        Console.WriteLine("Creating MPEG4 Compression Codec...");
    }

    public string GetCodec()
    {
        return "MP4";
    }
}