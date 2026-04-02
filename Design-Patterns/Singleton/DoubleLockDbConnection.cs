namespace Singleton;

public class DoubleLockDbConnection
{
    private static DoubleLockDbConnection? DoubleLockDbInstance;
    private DoubleLockDbConnection()
    {
    }

    public static DoubleLockDbConnection GetDbInstance()
    {
        if (DoubleLockDbInstance != null) return DoubleLockDbInstance;
        lock (typeof(DoubleLockDbConnection))
        {
            DoubleLockDbInstance ??= new DoubleLockDbConnection();
        }

        return DoubleLockDbInstance;
    }
}