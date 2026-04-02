namespace Singleton;

public class LazyDbConnection
{
    private static LazyDbConnection? LazyDbInstance;
    private LazyDbConnection(){}

    public static LazyDbConnection GetDbInstance()
    {
        if (LazyDbInstance == null)
        {
            LazyDbInstance = new LazyDbConnection();
        }
        return LazyDbInstance;
    }
}