using SingletonFramework.singleton;

namespace SingletonFramework.factories;

/// <summary>
/// The SingleThreadDisplay class represents another concrete
/// creator in the factory method pattern.
/// It extends the <see cref="Display"/> abstract class
/// </summary>
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