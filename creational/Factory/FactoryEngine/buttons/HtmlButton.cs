

namespace FactoryEngine.buttons
{
    /// <summary>
    /// The HtmlButton class represents another concrete product in the factory pattern.
    /// It also implements methods declared in the <see cref="IButton"/>  interface.
    /// </summary>
    internal class HtmlButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("Click me! To here 'Hello World!' from Button");
        }

        public void Render()
        {
            Console.WriteLine("<button> Click me!/button>");
        }
    }
}
