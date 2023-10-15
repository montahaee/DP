

namespace src.Buttons
{
    /// <summary>
    /// The HtmlButton class represents another concrete product in the factory pattern.
    /// It also implements methods declared in the <see cref="IButton"/>  interface.
    /// </summary>
    internal class HtmlButton : IButton
    {
        public void onClick()
        {
            Console.WriteLine("Click me! To heare 'Hello World!' from Button");
        }

        public void render()
        {
            Console.WriteLine("<button> Click me!/button>");
        }
    }
}
