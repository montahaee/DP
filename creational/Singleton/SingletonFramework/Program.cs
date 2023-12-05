using SingletonFramework.factories;
// using SingletonFramework.nonThreadSafe;


namespace SingletonFramework;

internal static class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine(@"If you see the same value, then singleton was reused (yah!)" + "\n" +
        //                   "If you see different values, then 2 singletons were created (boo!!)" + "\n\n" +
        //                   "RESULT:" + "\n");
        // Singleton nonThreadSafe = Singleton.GetInstance("FOO");
        // Singleton anotherNonThreadSafe = Singleton.GetInstance("BAR");
        // Console.WriteLine(nonThreadSafe.Value);
        // Console.WriteLine(anotherNonThreadSafe.Value);
        //
        // Console.WriteLine(@"If you see the same value, then singleton was reused (yah!)" + "\n" +
        //                   "If you see different values, then 2 singletons were created (boo!!)" + "\n\n" +
        //                   "RESULT:" + "\n");
        // ThreadFoo foo = new ThreadFoo();
        // Thread threadFoo = new Thread(foo.DisplaySingletonValue);
        // ThreadBar bar = new ThreadBar();
        // Thread threadBar = new Thread(bar.DisplaySingletonValue);
        // threadFoo.Start();
        // threadBar.Start();
        // ISingleton singleton = ThreadSafeSingleton.GetInstance("A");
        MultiThreadDisplay mDisplay = new MultiThreadDisplay();
        var mt = mDisplay.CreateThreadSafeSingleton("test");
        mDisplay.Preprint();
        mDisplay.ThreadSafe("test");
        Console.WriteLine(mt.Value());
        //
        // var umt = mDisplay.CreateThreadUnsafeSingleton("unsafeMultiThread");
        // mDisplay.Preprint();
        // Console.WriteLine(umt.Value());
        
        SingleThreadDisplay sDisplay = new SingleThreadDisplay();
        var stu = sDisplay.CreateThreadUnsafeSingleton("stuTest");
        sDisplay.Preprint();
        sDisplay.ThreadUnsafe("mTest");
        // sDisplay.TestSingleton("mTest");
        Console.WriteLine(stu.Value());
        // var sts = sDisplay.CreateThreadSafeSingleton("stsTest");
        // sDisplay.Preprint();
        // SingleThreadDisplay.ThreadSafe("mTest");
        // Console.WriteLine(sts.Value());

        



    }
    
    // class ThreadFoo
    // {
    //     public void DisplaySingletonValue()
    //     {
    //         Singleton singleton = Singleton.GetInstance("FOO");
    //         Console.WriteLine(singleton.Value);
    //     }
    // }
    //
    // class ThreadBar
    // {
    //     public void DisplaySingletonValue()
    //     {
    //         Singleton singleton = Singleton.GetInstance("BAR");
    //         Console.WriteLine(singleton.Value);
    //     }
    // }
}