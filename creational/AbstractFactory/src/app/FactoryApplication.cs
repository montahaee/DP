using src.buttons;
using src.checkboxes;
using src.Factories;

namespace src.app
{
    /// <summary>
    /// FactoryApplication represents the application that creates
    /// and paints GUI components.
    /// </summary>
    internal class FactoryApplication
    {
        // Stores a references to a button and checkbox interface.
        private IButton button;
        private ICheckbox checkbox;

        /// <summary>
        /// Initializes a new instance of the FactoryApplication class.
        /// </summary>
        /// <param name="gui">The GUI interface responsible for creating
        /// GUI components.</param>
        public FactoryApplication(IGUI gui) { 
            button = gui.createButton();
            checkbox = gui.createCheckbox();
        }


        /// <summary>
        /// Paints the GUI components created by the application.
        /// </summary>
        public void paint()
        {
            button.Paint();
            checkbox.Paint();
        }
    }
}
