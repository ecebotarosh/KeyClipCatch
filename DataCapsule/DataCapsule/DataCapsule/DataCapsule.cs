namespace DataCapsule.DataCapsule
{
    enum ContentType { image,text}
    public class DataCapsule
    {
        private ContentType _contentType;
        private string _date;

        public DataCapsule(string date)
        {
            this._contentType = ContentType.text;
            this._date = date;
        }
        public DataCapsule(System.Drawing.Image img)
        {
            this._contentType = ContentType.image;
            var imageStream = new System.IO.MemoryStream();
            img.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
            imageStream.Position = 0;
            var imageBytes = imageStream.ToArray();
            var ImageBase64 = System.Convert.ToBase64String(imageBytes);
            _date = ImageBase64;
            imageStream.Dispose();
        }
        
        public byte[]Data
        {
            get
            {
                if (_contentType == ContentType.image)
                    return System.Convert.FromBase64String(_date);
                else return System.Text.Encoding.UTF8.GetBytes(_date);
            }
        }
    }
}
