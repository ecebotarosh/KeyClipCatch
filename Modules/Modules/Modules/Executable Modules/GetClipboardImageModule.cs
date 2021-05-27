namespace Modules
{
    class GetClipboardImageModule : GetterModule
    {
        public override void Execute()
        {
            if (System.Windows.Forms.Clipboard.ContainsImage())
            {
                _data = new DataCapsule.DataCapsule.DataCapsule(System.Windows.Forms.Clipboard.GetImage());
            }
            else
            {
                throw new System.Exception("Clipboard does not contain an image!");
            }
        }
    }
}
