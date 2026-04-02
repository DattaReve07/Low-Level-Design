namespace Singleton;

public class EagerDbConnection
{
    private static readonly EagerDbConnection EagerDbInstance = new EagerDbConnection();
    private EagerDbConnection(){}

    public static EagerDbConnection GetDbInstance()
    {
        return EagerDbInstance;
    }
}