
/**************************************************************************
 *                                                                        *
 *  File:        GetterModule.cs                                          *
 *  Copyright:   (c) 2021, Cebotaros Emil                                 *
 *  E-mail:      emil.cebotaros@student.tuiasi.ro                         *
 *  Description: This module is an generic module meant to be inherited by*
 *               other modules, responsible for                           *
 *               getting clipboard contents.                              *
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
    public abstract class GetterModule
    {
        protected DataCapsule.DataCapsule.DataCapsule _data;

        public abstract void Execute();

        public DataCapsule.DataCapsule.DataCapsule GetData()
        {
            return _data;
        }
    }
}
