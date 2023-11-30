
using src.checkboxes;

namespace src.control
{

    /// <summary>
    /// The <see cref="OSControl"/> class is an abstract class
    /// that is inherited by concrete product classes like <see 
    /// cref=" src.buttons.WindowsButton"/>,<see cref="buttons.MacButton"/>,
    /// <see cref="checkboxes.WindowsChekcbox"/>, and <see cref="MacCheckbox"/>.
    /// It provides a base implementation for creating and initializing controls.
    /// </summary>
    internal abstract class OSControl
    {
        private Form _form ;
        private Control ? _control;

        public OSControl(string buttonText, EventHandler? onClickHandler)
        {
            this._form = new Form();
            InitializeControl(buttonText, onClickHandler);
        }

        public Form form { get => _form; set => _form = value; }
        public Control? control {  get => _control; set => _control = value;}

        /// <summary>
        /// Initializes the control with the given buttonText and onClickHandler.
        /// </summary>
        private void InitializeControl(string buttonText, EventHandler? onClickHandler)
        {
            this._control = CreateControlInstance();
            this._control.Text = buttonText;
            this._control.Location = new Point(70, 70);
            this._control.BackColor = Color.LightBlue;

            if (onClickHandler != null && this._control is Button button) {
                button.Click += onClickHandler;
            }
        }

        /// <summary>
        /// Abstract method to create a control instance.
        /// This method is implemented by subclasses of OSControl as we'v mentioned
        /// in the first comment. 
        /// </summary>
        protected abstract Control CreateControlInstance();

        /// <summary>
        /// Adds the control to the form and shows the form.
        /// </summary>
        public void Paint()
        {
            this._form.Controls.Add(this._control);
            this._form.ShowDialog();
        }
    }
}
