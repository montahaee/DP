using SingletonFramework.singleton;

namespace SingletonFramework.factories;

internal class MultiThreadDisplay : Display
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
        Task.Run(() => TestSingleton<ThreadSafeSingleton>(value));
    }
    
    
    private static void ThreadUnsafe(string value)
    {
        Task.Run(() => TestSingleton<ThreadUnsafeSingleton>(value));
    }

}