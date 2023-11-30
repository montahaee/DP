using SingletonFramework.singleton;

namespace SingletonFramework.factories;

public class MultiThreadDisplay : Display
{
    
    public ISingleton CreateThreadsafeSingleton(string value)
    {
        
        throw new NotImplementedException();
    }

    public ISingleton CreateThreadUnsafeSingleton(string value)
    {
        throw new NotImplementedException();
    }
}