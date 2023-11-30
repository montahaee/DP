using SingletonFramework.singleton;

namespace SingletonFramework.factories;

internal abstract class Display
{
    protected abstract  ISingleton CreateThreadsafeSingleton(string value);
    protected abstract ISingleton CreateSingleton(string value);
    protected abstract ISingleton CreateThreadUnsafeSingleton(string value);

    protected void TestSingleton(string value)
    {
        Console.WriteLine("If you see the same value, then singleton was reused (yah!)" + "\n" +
                          "If you see different values, then 2 singletons were created (boo!!)" + "\n\n" +
                          "RESULT:" + "\n");
        ISingleton threadUnsafeSingleton = CreateThreadUnsafeSingleton(value);
        var t = threadUnsafeSingleton.GetInstance(value)
        // ISingleton threadsafeSingleton = CreateThreadsafeSingleton(value);
    }
}