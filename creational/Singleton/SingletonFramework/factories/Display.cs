using SingletonFramework.singleton;

namespace SingletonFramework.factories;

/// <summary>
/// The abstract class Display represents a creator in the factory method pattern.
/// It declares the factory method that all concrete creators must implement.
/// </summary>
internal abstract class Display
{
    /// <summary>
    /// Creates a thread-safe singleton.
    /// </summary>
    /// <param name="value">A string value that can be used to initialize the Singleton instance.</param>
    /// <returns>A thread-safe singleton.</returns>
    internal abstract  ISingleton CreateThreadSafeSingleton(string value);
    
    /// <summary>
    /// Creates a thread-unsafe singleton.
    /// </summary>
    /// <param name="value">A string value that can be used to initialize the Singleton instance.</param>
    /// <returns>A thread-unsafe singleton.</returns>
    internal abstract ISingleton CreateThreadUnsafeSingleton(string value);

    /// <summary>
    /// Prints a predefined message to the console.
    /// </summary>
    internal void Preprint()
    {
        Console.WriteLine("If you see the same value, then singleton was reused (yah!)" + "\n" +
                          "If you see different values, then 2 singletons were created (boo!!)" + "\n\n" +
                          "RESULT:" + "\n");
    }
    
    /// <summary>
    /// Tests the singleton by resetting its instance and then getting its value.
    /// </summary>
    /// <param name="value">A string value that can be used to initialize the Singleton instance.</param>
    internal static void TestSingleton<T>(string value) where T : ISingleton 
    {
        T.ResetInstance();
        ISingleton singleton = T.GetInstance(value);
        Console.WriteLine(singleton.Value());
    }
}