/**************************************************************************
 *                                                                        *
 *  File:        Compressor.cs                                            *
 *  Copyright:   (c) 2021, Ion Chiriac                                    *
 *  E-mail:      ion.chiriac@student.tuiasi.ro                            *
 *  Description: Keylogger application with encapsulated data             *
 *               The component that compresses the data retrieved by      *
 *               the keylogger                                            *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

namespace Compressor
{
    /// <summary>
    /// Clasa Compressor genereaza fisiere .zip unde sunt stocate date
    /// </summary>
    public class Compressor
    {
        /// <summary>
        /// Datele preluate de la intrare sunt compresate si dupa asta sunt salvate de disc
        /// </summary>
        /// <param name="data">Datele preluate de la keylogger</param>
        /// <returns></returns>
        public static byte[] Compress(byte []data)
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
