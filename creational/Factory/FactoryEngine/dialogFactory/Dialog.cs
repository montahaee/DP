﻿using FactoryEngine.buttons;

namespace FactoryEngine.dialogFactory
{
    /// <summary>
    /// The abstract class Dialog represents a creator in the factory method pattern.
    /// It declares the factory method that all concrete creators must implement.
    /// </summary>
    internal abstract class Dialog
    {
        /// <summary>
        /// The renderWindow method is responsible for
        /// rendering the window on the screen.
        /// It uses the createButton factory method to create a button.
        /// </summary>
        public void RenderWindow()
        {
            IButton okButton = CreateButton();
            okButton.Render();
        }

        /// <summary>
        /// The createButton method is a factory method that creates a button.
        /// It must be implemented by all concrete creators.
        /// </summary>
        /// <returns>A button that implements the IButton interface.</returns>
        protected abstract IButton CreateButton();
    }
}
