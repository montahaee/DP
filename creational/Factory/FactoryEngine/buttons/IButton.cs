
namespace FactoryEngine.buttons
{
    /// <summary>
    /// The IButton interface represents a product in the factory pattern.
    /// It declares methods that all concrete products must implement.
    /// </summary>
    internal interface IButton
    {
        /// <summary>
        /// The render method is responsible for rendering
        /// the button on the screen.
        /// </summary>
        void Render();

        /// <summary>
        /// The onClick method is responsible for defining
        /// the behavior of the button when it is clicked.
        /// </summary>
        void OnClick();
    }
}
