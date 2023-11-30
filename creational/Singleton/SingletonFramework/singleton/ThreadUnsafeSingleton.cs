namespace SingletonFramework.singleton;

public class ThreadUnsafeSingleton : ISingleton
{
    private static ThreadUnsafeSingleton? _instance;
    internal readonly string Value;

    private ThreadUnsafeSingleton(string value)
    {
        // To lazy initialization
        try
        {
            Thread.Sleep(1000);
        }
        catch (ThreadInterruptedException e)
        {
            Console.WriteLine(e);
            throw;
        }

        this.Value = value;
    }


    public static ISingleton GetInstance(string value)
    {
        return _instance ??= new ThreadUnsafeSingleton(value);
    }
}