namespace Facade;

public class CodecFactory
{
    public CodecFactory()
    {
        Console.WriteLine("Creating Codec Factory...");
    }

    public Codec Extract(string format)
    {
        return format switch
        {
            "mp4" => new MPEG4CompressionCodec(),
            "mkv" => new MKVCompressionCodec(),
            _ => throw new NotSupportedException($"Format {format} is not supported.")
        };
    }
}