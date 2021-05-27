﻿namespace Modules.Generic_Modules
{
    abstract class SetterModule : IModule
    {
        protected object _content;
        public abstract void Execute();

        public abstract void Execute(object content);

        public void SetContent(object content)
        {
            if (content.GetType() == typeof(System.Drawing.Image) || content.GetType() == typeof(string))
            {
                _content = content;
            }
            else
            {
                throw new System.Exception("An invalid data type passed to the setter module.");
            }
        }
    }
}
