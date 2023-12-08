namespace SingletonFramework.singleton;

/// <summary>
/// The ThreadSafeSingleton class represents a concrete product in the factory pattern.
/// It also implements methods declared in the <see cref="ISingleton"/> interface.
/// </summary>
public class ThreadSafeSingleton : ISingleton
{
    private static volatile ThreadSafeSingleton? _instance;
    private static readonly object SyncRoot = new object();

    private string Value { get; set; }

    private ThreadSafeSingleton(string value)
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
                    new ThreadSafeSingleton(value), null);
            }
        }
        return _instance;
    }

    string ISingleton.Value()
    { 
        return this.Value;
    }
    
    public static void ResetInstance()
    {
        _instance = null;
    }
}