namespace SingletonFramework.singleton;

public class ThreadsafeSingleton : ISingleton
{
    private static volatile ThreadsafeSingleton? _instance;
    private static readonly object SyncRoot = new object();
    
    internal string Value { get; private set; }

    private ThreadsafeSingleton(string value)
    {
        this.Value = value;
    }

    public static ISingleton GetInstance(string value)
    {
        if (_instance == null)
        {
            lock (SyncRoot)
            {
                /*
                 * To ensure that only one Singleton is (in the case nullity of _instance)
                 * created, even if multiple threads call the function at the same time.
                 */
                Interlocked.CompareExchange(ref _instance,
                    new ThreadsafeSingleton(value), null);
            }
        }
        return _instance;
    }
}