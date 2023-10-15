using src.Buttons;


namespace src.DialogFactory
{
    /// <summary>
    /// The WindowsDialog class represents a concrete
    /// creator in the factory method pattern.
    /// It extends the <see cref="Dialog"/> abstract class
    /// and implements the createButton method.
    /// </summary>
    internal class WindowsDialog : Dialog
    {
        /// <summary>
        /// The createButton method is a factory method
        /// that creates a WindowsButton.
        /// </summary>
        /// <returns>A new instance of the <see cref="src.Buttons.WindowsButton"/> class.</returns>
        public override IButton createButton()
        {
            return new WindowsButton();
        }
    }
}
