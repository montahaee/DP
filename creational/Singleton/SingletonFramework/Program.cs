using SingletonFramework.nonThreadSafe;

namespace SingletonFramework;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("If you see the same value, then singleton was reused (yah!)" + "\n" +
                          "If you see different values, then 2 singletons were created (boo!!)" + "\n\n" +
                          "RESULT:" + "\n");
        Singleton nonThreadSafe = Singleton.GetInstance("FOO");
        Singleton anotherNonThreadSafe = Singleton.GetInstance("BAR");
        Console.WriteLine(nonThreadSafe.Value);
        Console.WriteLine(anotherNonThreadSafe.Value);
        
        Console.WriteLine("If you see the same value, then singleton was reused (yah!)" + "\n" +
                          "If you see different values, then 2 singletons were created (boo!!)" + "\n\n" +
                          "RESULT:" + "\n");
        // ThreadFoo foo = new ThreadFoo();
        // Thread threadFOO = new Thread();
        
    }
    
    static class ThreadFoo
    {
        public static void DisplaySingletonValue()
        {
            Singleton singleton = Singleton.GetInstance("FOO");
            Console.WriteLine(singleton.Value);
        }
    }
}