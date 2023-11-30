namespace SingletonFramework;

public class SingletonStrategy
{
    public enum SingletonType
    {
        Threadsafe,
        NonThreadsafe
    }

    private SingletonType _type;

    public SingletonStrategy(SingletonType type)
    {
        _type = type;
    }
    
}