
namespace SingletonFramework.nonThreadSafe;

public class Singleton
{
    private static Singleton? _instance;
    internal string Value;

    private Singleton(string value)
    {
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

    public static Singleton GetInstance(string value)
    {
        return _instance ??= new Singleton(value);
    }
}