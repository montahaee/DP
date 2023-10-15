using src.DialogFactory;
namespace src
{
    class Program
    {
        private static Dialog? dialog; 
        public static void Main(string[] args) {
            cofigure();
            RunBusinessLogic();
        }

        /// <summary>
        /// The configure method is responsible for configuring the application.
        /// It creates an appropriate dialog depending on the operating system.
        /// </summary>
        private static void cofigure()
        {
            if (Environment.OSVersion.VersionString.Contains("Windows"))
            {
                dialog = new WindowsDialog();
            }
            else
            {
                dialog = new HtmlDialog();
            }

        }

        /// <summary>
        /// The RunBusinessLogic method is responsible for
        /// running the business logic of the application.
        /// It renders the window of the dialog.
        /// </summary>
        private static void RunBusinessLogic() => dialog?.renderWindow();
    }
}

