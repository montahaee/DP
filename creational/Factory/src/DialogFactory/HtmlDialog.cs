using src.Buttons;


namespace src.DialogFactory
{
    /// <summary>
    /// The HtmlDialog class represents a concrete creator
    /// in the factory method pattern.
    /// It extends the <see cref="Dialog"/> abstract class and 
    /// implements the createButton method.
    /// </summary>
    internal class HtmlDialog : Dialog
    {
        /// <summary>
        /// The createButton method is a factory method that creates an HtmlButton.
        /// </summary>
        /// <returns>A new instance of the <see cref="src.Buttons.HtmlButton"/>
        /// class.</returns>
        public override IButton createButton()
        {
            return new HtmlButton();
        }
    }
}
