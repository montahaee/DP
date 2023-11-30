using src.buttons;
using src.checkboxes;

namespace src.factories
{
    /// <summary>
    /// The MacGUI class represents a concrete factory in the abstract factory
    /// pattern. It implements the IGUI interface.
    /// </summary>
    internal class MacGui : IGui
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
