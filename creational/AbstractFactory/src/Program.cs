using src.app;
using src.checkboxes;
using src.Factories;

namespace src
{
    /// <summary>
    /// The Program class is the entry point of the application.
    /// It uses the <see cref="FactoryApplication"/> class to create and
    /// paint GUI elements.
    /// FactoryApplication acts as the client in the Abstract Factory design pattern.
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
            FactoryApplication application;
            IGUI gUI;
            string osName = Environment.OSVersion.VersionString.ToLower();

            if (osName.Contains("mac"))
            {
                gUI = new MacGUI();
                application = new FactoryApplication(gUI);
            } else
            {
                gUI = new WindowsGUI();
                application = new FactoryApplication(gUI);
            }
            return application;
        }
    }
}
