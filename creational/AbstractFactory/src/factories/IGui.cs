using src.buttons;
using src.checkboxes;

namespace src.factories
{
    /// <summary>
    /// The <see cref="IGui"/> interface defines the contract
    /// for GUI factories.
    /// </summary>
    internal interface IGui
    {
        /// <summary>
        /// Creates a new button.
        /// </summary>
        IButton CreateButton();

        /// <summary>
        /// Creates a new checkbox.
        /// </summary>
        ICheckbox CreateCheckbox();
    }
}
