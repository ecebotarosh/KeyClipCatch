using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.DataCapsule;
namespace Proiect.Compressor
{
    public class Compressor
    {
        private DataCapsule.DataCapsule _dataCapsule;
        public byte[] Compress()
        {
            using (var compressedStream = new MemoryStream())
            using (GZipStream zipStream = new GZipStream(compressedStream, CompressionMode.Compress))
            {
                zipStream.Write(_dataCapsule.Data, 0, _dataCapsule.Data.Length);
                zipStream.Close();
                return compressedStream.ToArray();
            }
        }
    }
}
