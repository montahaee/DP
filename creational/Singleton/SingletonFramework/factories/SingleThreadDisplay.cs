using SingletonFramework.singleton;

namespace SingletonFramework.factories;

// public class SingleThreadDisplay : Display1
public class SingleThreadDisplay : Display
{
    // public override void Print(string value)
    // {
    //     base.Print(value);
    //     Con
    // }
    protected override ISingleton CreateThreadsafeSingleton(string value)
    {
        return ThreadsafeSingleton.GetInstance(value);
    }

    protected override ISingleton CreateThreadUnsafeSingleton(string value)
    {
        var t = new ThreadsafeSingleton(value);
        return ThreadUnsafeSingleton.GetInstance(value);
    }

    protected override void TestSingleton(string value)
    {
        base.TestSingleton(value);
        switch (this.CreateThreadsafeSingleton(value))
        {
            
        }
    }
}