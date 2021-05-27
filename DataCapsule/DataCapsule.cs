using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Proiect.DataCapsule
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
        public DataCapsule(Image img)
        {
            this._contentType = ContentType.image;
            var imageStream = new MemoryStream();
            img.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
            imageStream.Position = 0;
            var imageBytes = imageStream.ToArray();
            var ImageBase64 = Convert.ToBase64String(imageBytes);
            _date = ImageBase64;
            System.Console.WriteLine(_date);
            imageStream.Dispose();
        }
        
        public byte[]Data
        {
            get
            {
                if (_contentType == ContentType.image)
                    return Convert.FromBase64String(_date);
                else return Encoding.UTF8.GetBytes(_date);
            }
        }
    }
}
