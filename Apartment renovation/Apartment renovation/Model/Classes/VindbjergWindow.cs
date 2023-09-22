using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_renovation.Model.Classes
{
    internal class VindbjergWindow : WindowCleaner
    {
        #region Constructor
        internal VindbjergWindow(string color, string guarantee, string WindowsType, ushort mainDoorPrice, ushort backDoorPrice, byte backDoorBD60, byte backDoorBD40)
            : base(color, guarantee, WindowsType, mainDoorPrice, backDoorPrice, backDoorBD60, backDoorBD40)
        {

        }
        #endregion

        #region tostring

        public override string ToString()
        {
            return base.ToString();
        }

        #endregion
    }
}
