
namespace FactoryEngine.buttons
{
    /// <summary>
    /// The WindowsButton class represents a concrete product
    /// in the factory pattern.
    /// It implements methods declared in the <see cref="IButton"/> interface.
    /// </summary>
    internal class WindowsButton : IButton
    {
        private readonly Form _form;
        private readonly Button _button;
        private readonly Panel _panel;

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
            AutoSizeMode = AutoSizeMode.GrowAndShrink,}) { }

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
            this._form = form;
            this._button = button;
            this._panel = panel;
        }

        /// <summary>
        /// This method defines the behavior of the Windows button
        /// when it is clicked.
        /// </summary>
        public void OnClick()
        {
            _button.Text = "Exit";
            _button.Size = new Size(80, 25);
            _button.Anchor = AnchorStyles.None;
            _button.Location = new Point((_panel.Width - _button.Width) / 2,
                (_panel.Height - _button.Height) / 2);
            _button.Click += (sender, e) =>
            {
                _form.Visible = true;
                Application.Exit();
            };
        }

        /// <summary>
        /// This method renders the button on the Windows screen.
        /// </summary>
        public void Render()
        {
            _form.FormClosing += (sender, e) => Application.Exit();

            Label label = new Label()
            {
                Text = "Hello World!",
                BackColor = Color.FromArgb(235, 220, 126),
                Font = new Font("Dialog", 24, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
            };
            _panel.Controls.Add(label);
            OnClick();

            _panel.Controls.Add(_button);

            _form.Controls.Add(_panel);
            _form.Size = new Size(320, 200);
            _form.Visible = true;
            Application.Run(_form);

        }
    }
}
