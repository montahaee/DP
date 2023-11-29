namespace SingletonFramework.threadSafe;

public sealed class Singleton
{
    private static volatile Singleton? _instance;
    private static readonly object SyncRoot = new object();
    
    internal string Value { get; private set; }

    private Singleton(string value)
    {
        this.Value = value;
    }

    public static Singleton GetInstance(string value)
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
                    new Singleton(value), null);
            }
        }
        return _instance;
    }
}