/**************************************************************************
 *                                                                        *
 *  File:        SetterModule.cs                                          *
 *  Copyright:   (c) 2021, Cebotaros Emil                                 *
 *  E-mail:      emil.cebotaros@student.tuiasi.ro                         *
 *  Description: This module is an generic module meant to be inherited by*
 *               other modules, responsible for                           *
 *               setting clipboard contents.                              *
 *                                                                        *
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
    /// <summary>
    /// 
    /// </summary>
    abstract class SetterModule
    {
        protected object _content;

        public abstract void Execute(object content);

        public void SetContent(object content)
        {
            if (content.GetType() == typeof(System.Drawing.Image) || content.GetType() == typeof(string))
            {
                _content = content;
            }
            else
            {
                throw new System.Exception("An invalid data type passed to the setter module.");
            }
        }
    }
}
