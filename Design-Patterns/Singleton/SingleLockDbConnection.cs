using System.Runtime.CompilerServices;

namespace Singleton;

public class SingleLockDbConnection
{
    private static SingleLockDbConnection? SingleLockDbInstance;
    private static readonly object LockObject = new object();

    private SingleLockDbConnection()
    {
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public static SingleLockDbConnection GetDbInstance()
    {
        SingleLockDbInstance ??= new SingleLockDbConnection();

        return SingleLockDbInstance;
    }
}