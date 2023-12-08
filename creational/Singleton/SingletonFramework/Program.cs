using SingletonFramework.factories;

namespace SingletonFramework;

internal static class Program
{
    public static void Main(string[] args)
    {
        MultiThreadDisplay mDisplay = new MultiThreadDisplay();
        var mts = mDisplay.CreateThreadSafeSingleton("test");
        mDisplay.Preprint();
        mDisplay.ThreadSafe("test");
        Console.WriteLine(mts.Value());

        
        SingleThreadDisplay sDisplay = new SingleThreadDisplay();
        var stu = sDisplay.CreateThreadUnsafeSingleton("stuTest");
        sDisplay.Preprint();
        sDisplay.ThreadUnsafe("mTest");
        Console.WriteLine(stu.Value());
    }
}