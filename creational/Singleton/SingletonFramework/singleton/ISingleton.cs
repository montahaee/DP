namespace SingletonFramework.singleton;

public interface ISingleton
{
    static abstract ISingleton GetInstance(string value);
    string Value();
}