using src.buttons;
using src.checkboxes;

namespace src.factories
{
    /// <summary>
    /// The <see cref="WindowsGUI"/> class represents a concrete factory in the
    /// abstract factory pattern.It implements the <see cref="IGUI"/> interface.
    /// </summary>
    internal class WindowsGUI : IGUI
    {
        public IButton createButton()
        {
            return new WindowsButton();
        }

        public ICheckbox createCheckbox()
        {
            return new WindowsChekcbox();
        }
    }
}
