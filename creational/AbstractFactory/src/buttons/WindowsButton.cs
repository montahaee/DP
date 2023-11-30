using src.control;

namespace src.buttons
{
    /// <summary>
    /// The <see cref="WindowsButton"/> class represents a concrete product in the abstract factory pattern.
    /// It inherits from the <see cref="OSControl"/> class and implements the <see cref="IButton"/> interface.
    /// </summary>
    internal class WindowsButton :  OSControl, IButton
    {

        /// <summary>
        /// The WindowsButton constructor initializes a new 
        /// instance of the <see cref="WindowsButton"/> class.
        /// </summary>
        public WindowsButton() : base("WinOk", (sender, e) =>
        {
            if (sender is Button button) {
                MessageBox.Show("${Win Button} Clicked!");
            }
        }){
            this.form.Text = "Win Button";
        }

        /// <summary>
        /// Handles the button click event.
        /// </summary>
        private static void OnButtonClick(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                MessageBox.Show("${Win Button} Clicked!");
            } else if (e is MouseEventArgs winMouse)
            {
                bool moused = winMouse.Button == MouseButtons.Left;
                moused |= winMouse.Button == MouseButtons.Right;
                moused |= winMouse.Button == MouseButtons.Middle;

                if (moused)
                {
                    MessageBox.Show("Win Mouse button clicked!");
                }
                
            } else
            {
                MessageBox.Show("Unknown Win Button Clicked!");
            }
        }

        /// <summary>
        /// Creates a new instance of a button control with Windows view.
        /// </summary>
        protected override Control CreateControlInstance()
        {
            return new Button() {
                Size = new Size(100, 50),
                ForeColor = Color.White,
                BackColor = Color.LightBlue
            };
        }
    }
}
