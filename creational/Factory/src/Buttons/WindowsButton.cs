
namespace src.Buttons
{
    /// <summary>
    /// The WindowsButton class represents a concrete product
    /// in the factory pattern.
    /// It implements methods declared in the <see cref="IButton"/> interface.
    /// </summary>
    internal class WindowsButton : IButton
    {
        private Form form;
        private Button button;
        private Panel panel;

        /// <summary>
        /// The WindowsButton constructor initializes a new 
        /// instance of the <see cref="WindowsButton"/> class.
        /// </summary>
        public WindowsButton() : this(new Form(), new Button(), new TableLayoutPanel()
        {
            RowCount = 2,
            ColumnCount = 1,
            Dock = DockStyle.Fill,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,})
        {
        }

        /// <summary>
        /// The WindowsButton constructor initializes a new instance of the
        /// WindowsButton class with the specified form, button, and panel.
        /// </summary>
        /// <param name="form">The form to be associated with this 
        /// instance of the WindowsButton class.</param>
        /// <param name="button">The button to be associated with this
        /// instance of the WindowsButton class.</param>
        /// <param name="panel">The panel to be associated with this
        /// instance of the WindowsButton class.</param>
        public WindowsButton(Form form, Button button, Panel panel)
        {
            this.form = form;
            this.button = button;
            this.panel = panel;
        }

        /// <summary>
        /// This method defines the behavior of the Windows button
        /// when it is clicked.
        /// </summary>
        public void onClick()
        {
            button.Text = "Exit";
            button.Size = new Size(80, 25);
            button.Anchor = AnchorStyles.None;
            button.Location = new Point((panel.Width - button.Width) / 2,
                (panel.Height - button.Height) / 2);
            button.Click += (sender, e) =>
            {
                form.Visible = true;
                Application.Exit();
            };
        }

        /// <summary>
        /// This method renders the button on the Windows screen.
        /// </summary>
        public void render()
        {
            form.FormClosing += (sender, e) => Application.Exit();

            Label label = new Label()
            {
                Text = "Hello World!",
                BackColor = Color.FromArgb(235, 220, 126),
                Font = new Font("Dialog", 24, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
            };
            panel.Controls.Add(label);
            onClick();

            panel.Controls.Add(button);

            form.Controls.Add(panel);
            form.Size = new Size(320, 200);
            form.Visible = true;
            Application.Run(form);

        }
    }
}
