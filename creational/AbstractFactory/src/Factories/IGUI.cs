using src.buttons;
using src.checkboxes;


namespace src.Factories
{
    /// <summary>
    /// The <see cref="IGUI"/> interface defines the contract for GUI factories.
    /// </summary>
    internal interface IGUI
    {
        /// <summary>
        /// Creates a new button.
        /// </summary>
        IButton createButton();

        /// <summary>
        /// Creates a new checkbox.
        /// </summary>
        ICheckbox createCheckbox();
    }
}
