using src.buttons;
using src.checkboxes;

namespace src.factories
{
    /// <summary>
    /// The <see cref="IGui"/> class represents a concrete factory in the
    /// abstract factory pattern.It implements the <see cref="WindowsGui"/> interface.
    /// </summary>
    internal class WindowsGui : IGui
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckcbox();
        }
    }
}
