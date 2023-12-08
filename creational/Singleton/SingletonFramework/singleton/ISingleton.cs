namespace SingletonFramework.singleton;

/// <summary>
/// The ISingleton interface represents Single pattern a product combined
/// in the factory pattern. It declares methods that all concrete products
/// must implement in any classes that acts as a Singleton.
/// </summary>
public interface ISingleton
{
    /// <summary>
    /// GetInstance is a static method that returns an instance of a class
    /// that implements ISingleton.
    /// </summary>
    /// <param name="value">A string value that can be used to initialize
    /// the Singleton instance.</param>
    /// <returns>An instance of a class that implements ISingleton.</returns>
    static abstract ISingleton GetInstance(string value);
    
    /// <summary>
    /// Value is a method that returns a string value associated
    /// with the Singleton instance.
    /// </summary>
    /// <returns>A string value associated with the Singleton instance.</returns>
    string Value();

    /// <summary>
    /// ResetInstance resets the Singleton instance.
    /// </summary>
    static abstract void ResetInstance();
}