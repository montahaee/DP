// using SingletonFramework.factories;
// using SingletonFramework.singleton;
// using SingletonFramework.threadSafe;
//
// namespace SingletonFramework.app;
//
// public class FactoryApplication
// {
//     // TODO find some way to implement the FactoryApplication from AbstractFactory.
//     // private readonly ISingleton _singleton;
//     // private readonly Display _display;
//     private readonly ISingleton _singleton;
//     private readonly Display _display;
//     
//
//     public FactoryApplication(string singleton)
//     {
//         _singleton = _display.CreateThreadSafeSingleton(singleton);
//         // _display = display.
//         // _singleton = display.
//         _singleton = singleton.CreateThreadsafeSingleton()
//         
//     }
//
//     
//     internal void ThreadSafe(string value)
//     {
//         Console.WriteLine("If you see the same value, then singleton was reused (yah!)" + "\n" +
//                           "If you see different values, then 2 singletons were created (boo!!)" + "\n\n" +
//                           "RESULT:" + "\n");
//         ISingleton threadUnsafeSingleton = CreateThreadUnsafeSingleton(value);
//         Console.WriteLine(threadUnsafeSingleton.Value());
//         // ISingleton threadsafeSingleton = CreateThreadSafeSingleton(value);
//     }
//
// }