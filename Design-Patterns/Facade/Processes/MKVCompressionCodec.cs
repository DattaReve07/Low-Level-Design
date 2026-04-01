namespace Facade;

public class MKVCompressionCodec : Codec
{
    public MKVCompressionCodec()
    {
        Console.WriteLine("Creating MKV Compression Codec...");
    }

    public string GetCodec()
    {
        return "MKV";
    }
}