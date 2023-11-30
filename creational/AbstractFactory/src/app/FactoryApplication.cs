using src.buttons;
using src.checkboxes;
using src.factories;

namespace src.app
{
    /// <summary>
    /// FactoryApplication represents the application that creates
    /// and paints GUI components without knowledge about the concrete factory.
    /// </summary>
    internal class FactoryApplication
    {
        // Stores a references to a button and checkbox interface.
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        /// <summary>
        /// Initializes a new instance of the FactoryApplication class.
        /// </summary>
        /// <param name="gui">The GUI interface responsible for creating
        /// GUI components.</param>
        public FactoryApplication(IGui gui) { 
            _button = gui.CreateButton();
            _checkbox = gui.CreateCheckbox();
        }


        /// <summary>
        /// Paints the GUI components created by the application.
        /// </summary>
        public void Paint()
        {
            _button.Paint();
            _checkbox.Paint();
        }
    }
}