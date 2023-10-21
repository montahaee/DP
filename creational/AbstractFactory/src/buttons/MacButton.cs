using src.control;


namespace src.buttons
{
    /// <summary>
    /// The <see cref="MacButton"/> class represents a concrete product
    /// in the abstract factory pattern. It inherits from the <see cref="OSControl"/>
    /// class and implements the <see cref="IButton"/> interface.
    internal class MacButton :  OSControl,IButton
    {
        public MacButton() : base("MacOk", OnButtonClick) {
            this.form.Text = "Mac Button";
        }

        /// <summary>
        /// Handles the button click event.
        /// </summary>
        private static void OnButtonClick(object? sender, EventArgs e) {
            if (sender is Button) {
                MessageBox.Show("Mac Button Clicked!");
            } else if (e is MouseEventArgs macMous)
            {
                bool maused = macMous.Button == MouseButtons.Left;
                maused |= macMous.Button == MouseButtons.Right;
                maused |= macMous.Button == MouseButtons.Middle;

                if (maused)
                {
                    MessageBox.Show("Mac Mouse button clicked!");
                }
            } else
            {
                MessageBox.Show("Uknown Mac Button Clicked!");
            }
        }

        /// <summary>
        /// Creates a new instance of a button with Mac view control.
        /// </summary>
        protected override Control CreateControlInstance()
        {
           return new Button
            {
                Size = new Size(150, 75),
                ForeColor = Color.Black,
                BackColor = Color.LightSkyBlue
            };
        }
    }
}
