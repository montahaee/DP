using src.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.checkboxes
{
    internal class MacCheckbox : OSControl, ICheckbox
    {
        public MacCheckbox() : 
            base("Mac Checkbox" , OnChekboxClick)
        {
        }



        private static void OnChekboxClick(object? sender, EventArgs e)
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
                    MessageBox.Show($"Mac Checkbox {(checkBox.Checked ? "Checked" : "Unchecked")}");
                    MessageBox.Show($"Key Code: {key.KeyCode}");
                }
            }
            else
            {
                MessageBox.Show("Unknown Mac Checkbox Clicked!");
            }
        }

        protected override Control CreateControlInstance()
        {
            return new CheckBox
            {
                Size = new Size(225, 45),
                ForeColor = Color.White
            };
        }
    }
}
