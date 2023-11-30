using src.control;

namespace src.checkboxes
{
    internal class WindowsCheckcbox : OSControl, ICheckbox
    {
        public WindowsCheckcbox() : base("WinCheckbox", OnCheckboxClick)
        {
        }

        /// <summary>
        /// Handles the checkbox click event.
        /// </summary>
        private static void OnCheckboxClick(object? sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (e is MouseEventArgs mouse)
                {
                    MessageBox.Show(
                        $"Windows Checkbox {(checkBox.Checked ? "Checked" : "Unchecked")}");
                    MessageBox.Show($"Mouse X: {mouse.X}, Mouse Y: {mouse.Y}");
                }
                else if (e is KeyEventArgs key)
                {
                    MessageBox.Show($"Windows Checkbox {(checkBox.Checked ? "Checked" : "Unchecked")}");
                    MessageBox.Show($"Key Code: {key.KeyCode}");
                }
            }
            else
            {
                MessageBox.Show("Unknown Win Checkbox Clicked!");
            }

        }

        /// <summary>
        /// Creates a new instance of a checkbox control.
        /// </summary>
        protected override Control CreateControlInstance()
        {
            return new CheckBox()
            {
                Size = new Size(150, 30),
                ForeColor = Color.Black,
            };
        }
    }
}


