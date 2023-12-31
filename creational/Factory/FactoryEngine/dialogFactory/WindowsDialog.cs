﻿using FactoryEngine.buttons;

namespace FactoryEngine.dialogFactory
{
    /// <summary>
    /// The WindowsDialog class represents a concrete
    /// creator in the factory method pattern.
    /// It extends the <see cref="Dialog"/> abstract class
    /// and implements the createButton method.
    /// </summary>
    internal class WindowsDialog : Dialog
    {
        /// <summary>
        /// The createButton method is a factory method
        /// that creates a WindowsButton.
        /// </summary>
        /// <returns>A new instance of the <see cref="WindowsButton"/> class.</returns>
        protected override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
