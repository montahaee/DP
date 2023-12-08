namespace SingletonFramework.singleton;

/// <summary>
/// The ThreadUnsafeSingleton class represents another concrete product in the factory
/// pattern. It also implements methods declared in the <see cref="ISingleton"/> interface.
/// </summary>
public class ThreadUnsafeSingleton : ISingleton
{
    private static ThreadUnsafeSingleton? _instance;
    private readonly string _value;

    private ThreadUnsafeSingleton(string value)
    {
        // To lazy initialization
        try
        {
            Thread.Sleep(2023);
        }
        catch (ThreadInterruptedException e)
        {
            Console.WriteLine(e);
            throw;
        }

        this._value = value;
    }
    
    public static ISingleton GetInstance(string value)
    {
        return _instance ??= new ThreadUnsafeSingleton(value);
    }

    public string Value()
    {
        return this._value;
    }

    public static void ResetInstance()
    {
        _instance = null;
    }
}