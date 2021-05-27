namespace Compressor
{
    public class Compressor
    {
        public byte[] Compress(byte []data)
        {
            using (var compressedStream = new System.IO.MemoryStream())
            using (System.IO.Compression.GZipStream zipStream = new System.IO.Compression.GZipStream(compressedStream, System.IO.Compression.CompressionMode.Compress))
            {
                zipStream.Write(data, 0, data.Length);
                zipStream.Close();
                return compressedStream.ToArray();
            }
        }
    }
}
