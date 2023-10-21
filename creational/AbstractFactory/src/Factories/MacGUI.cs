using src.buttons;
using src.checkboxes;

namespace src.Factories
{
    /// <summary>
    /// The MacGUI class represents a concrete factory in the abstract factory
    /// pattern. It implements the IGUI interface.
    /// </summary>
    internal class MacGUI : IGUI
    {
        public IButton createButton()
        {
            return new MacButton();
        }

        public ICheckbox createCheckbox()
        {
            return new MacCheckBox();
        }
    }
}
