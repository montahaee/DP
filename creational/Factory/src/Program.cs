using src.DialogFactory;
namespace src
{
    internal static class Program
    {
        private static Dialog? _dialog; 
        public static void Main(string[] args) {
            Configure();
            RunBusinessLogic();
        }

        /// <summary>
        /// The configure method is responsible for configuring the application.
        /// It creates an appropriate dialog depending on the operating system.
        /// </summary>
        private static void Configure()
        {
            if (Environment.OSVersion.VersionString.Contains("Windows"))
            {
                _dialog = new WindowsDialog();
            }
            else
            {
                _dialog = new HtmlDialog();
            }

        }

        /// <summary>
        /// The RunBusinessLogic method is responsible for
        /// running the business logic of the application.
        /// It renders the window of the dialog.
        /// </summary>
        private static void RunBusinessLogic() => _dialog?.RenderWindow();
    }
}

