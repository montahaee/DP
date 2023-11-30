namespace SingletonFramework.factories;

public class Display1
{
    public virtual void Print (string value)
    {
        Console.WriteLine(@"If you see the same value, then singleton was reused (yah!)" + "\n" +
                          "If you see different values, then 2 singletons were created (boo!!)" + "\n\n" +
                          "RESULT:" + "\n");
    }
}