namespace Modules
{
    class GetClipboardTextModule : GetterModule
    {
        public override void Execute()
        {
            if (System.Windows.Forms.Clipboard.ContainsText())
            {
                _data = System.Windows.Forms.Clipboard.GetText();
            }
            else
            {
                throw new System.Exception("Clipboard does not contain text!");
            }
        }

        public override object GetData()
        {
            return _data;
        }
    }
}
