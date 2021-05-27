namespace Modules
{
    class SetClipboardImageModule : Generic_Modules.SetterModule
    {
        public override void Execute()
        {
            throw new System.NotSupportedException("You should use Execute with an argument");
        }

        public override void Execute(object content)
        {
            SetContent(content);
            if (content.GetType() == typeof(System.Drawing.Image))
            {
                System.Windows.Forms.Clipboard.SetImage((System.Drawing.Image)_content);
            }
            else
            {
                throw new System.Exception("You did not pass an image as a parameter!");
            }
        }
    }
}
