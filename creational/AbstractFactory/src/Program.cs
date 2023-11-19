using src.app;
using src.factories;

namespace src
{
    /// <summary>
    /// The Program class is the entry point of the application.
    /// It uses the <see cref="FactoryApplication"/> class to create and
    /// paint GUI elements.
    /// FactoryApplication acts as the client in the Abstract Factory design pattern.
    /// It picks the factory type and creates that in run time depending
    /// enviroment variable.
    internal class Program
    {

        public static void Main(string[] args)
        {
            FactoryApplication app = configureApplication();
            app.paint();
        }

        /// <summary>
        /// The configureApplication method creates a new FactoryApplication instance.
        /// It uses the OS name to determine which GUI to use (Mac or Windows).
        /// </summary>
        private static FactoryApplication configureApplication()
        {
            string osName = Environment.OSVersion.VersionString.ToLower();
            if (osName.Contains("mac"))
            {
                return new FactoryApplication(new MacGUI());
            } else if (osName.Contains("windows"))
            {
                return new FactoryApplication(new WindowsGUI());
            } else
            {
                throw new NotSupportedException("The operating system is not supported.");
            }
            
        }
    }
}
