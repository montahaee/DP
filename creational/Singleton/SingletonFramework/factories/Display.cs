using SingletonFramework.singleton;

namespace SingletonFramework.factories;

internal abstract class Display
{
    internal abstract  ISingleton CreateThreadSafeSingleton(string value);
    internal abstract ISingleton CreateThreadUnsafeSingleton(string value);

    // internal void ThreadSafe(string value)

    // internal abstract void ThreadSafe(string value);
    // {
    internal void Preprint()
    {
        Console.WriteLine("If you see the same value, then singleton was reused (yah!)" + "\n" +
                          "If you see different values, then 2 singletons were created (boo!!)" + "\n\n" +
                          "RESULT:" + "\n");
    }
    internal static void TestSingleton<T>(string value) where T : ISingleton 
    {
        ISingleton singleton = T.GetInstance(value);
        Console.WriteLine(singleton.Value());
        // ISingleton threadsafeSingleton = CreateThreadSafeSingleton(value);
    }
    //   internal void TestSingleton(string value)
    //   {
    //       var singleton = CreateThreadUnsafeSingleton(value);
    //       Console.WriteLine(singleton.Value());
    //     // ISingleton threadsafeSingleton = CreateThreadSafeSingleton(value);
    // }
    
    

}