namespace Modules
{
    class SetClipboardTextModule : Generic_Modules.SetterModule
    {
        public override void Execute()
        {
            throw new System.NotSupportedException("You should use Execute with an argument");           
        }

        public override void Execute(object content)
        {
            SetContent(content);
            if (content.GetType() == typeof(string))
            {
                System.Windows.Forms.Clipboard.SetText(System.Text.RegularExpressions.Regex.Unescape((string)_content));
            }
            else
            {
                throw new System.Exception("You did not pass string as a parameter!");
            }    
        }
    }
}
