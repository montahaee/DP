using SingletonFramework.singleton;

namespace SingletonFramework.factories;

// public class SingleThreadDisplay : Display1
internal class SingleThreadDisplay : Display
{
    internal override ISingleton CreateThreadSafeSingleton(string value)
    {
        return ThreadSafeSingleton.GetInstance(value);
    }

    internal override ISingleton CreateThreadUnsafeSingleton(string value)
    {
        return ThreadUnsafeSingleton.GetInstance(value);
    }

    internal void ThreadSafe(string value)
    {
        TestSingleton<ThreadSafeSingleton>(value);
    } 
    
    internal void ThreadUnsafe(string value)
    {
        TestSingleton<ThreadUnsafeSingleton>(value);
    }
}