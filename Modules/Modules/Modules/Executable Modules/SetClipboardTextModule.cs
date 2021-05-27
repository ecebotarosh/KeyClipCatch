/**************************************************************************
 *                                                                        *
 *  File:        SetClipboardTextModule.cs                                *
 *  Copyright:   (c) 2021, Cebotaros Emil                                 *
 *  E-mail:      emil.cebotaros@student.tuiasi.ro                         *
 *  Description: This module is responsible for overwriting the clipboard *
 *               content with user-provided text                          *
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
    class SetClipboardTextModule : SetterModule
    {
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
