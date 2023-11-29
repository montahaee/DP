using SingletonFramework.nonThreadSafe;

namespace SingletonFramework;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(@"If you see the same value, then singleton was reused (yah!)" + "\n" +
                          "If you see different values, then 2 singletons were created (boo!!)" + "\n\n" +
                          "RESULT:" + "\n");
        Singleton nonThreadSafe = Singleton.GetInstance("FOO");
        Singleton anotherNonThreadSafe = Singleton.GetInstance("BAR");
        Console.WriteLine(nonThreadSafe.Value);
        Console.WriteLine(anotherNonThreadSafe.Value);
        
        Console.WriteLine(@"If you see the same value, then singleton was reused (yah!)" + "\n" +
                          "If you see different values, then 2 singletons were created (boo!!)" + "\n\n" +
                          "RESULT:" + "\n");
        ThreadFoo foo = new ThreadFoo();
        Thread threadFoo = new Thread(foo.DisplaySingletonValue);
        ThreadBar bar = new ThreadBar();
        Thread threadBar = new Thread(bar.DisplaySingletonValue);
        threadFoo.Start();
        threadBar.Start();
        
    }

    // TODO think about the integration of two types of singleton here maybe  using switch or abstract factory
    // private static void DisplaySingletonValue(string value)
    // {
    //     Singleton 
    // }

    class ThreadFoo
    {
        public void DisplaySingletonValue()
        {
            Singleton singleton = Singleton.GetInstance("FOO");
            Console.WriteLine(singleton.Value);
        }
    }

    class ThreadBar
    {
        public void DisplaySingletonValue()
        {
            Singleton singleton = Singleton.GetInstance("BAR");
            Console.WriteLine(singleton.Value);
        }
    }
}