/**************************************************************************
 *                                                                        *
 *  File:        GetClipboardImageModule.cs                               *
 *  Copyright:   (c) 2021, Cebotaros Emil                                 *
 *  E-mail:      emil.cebotaros@student.tuiasi.ro                         *
 *  Description: This module is responsible for retrieving                *
 *               images from the clipboard.                               *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
namespace Modules
{
    public class GetClipboardImageModule : GetterModule
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
