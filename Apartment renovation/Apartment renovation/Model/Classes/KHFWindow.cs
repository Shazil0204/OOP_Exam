using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_renovation.Model.Classes
{
    internal class KHFWindow : WindowCleaner
    {
        #region Constructor
        internal KHFWindow(string color, string guarantee, string WindowsType, bool isFrostedGlass, ushort mainDoorPrice, ushort backDoorPrice, bool isbackDoorBD60, bool isbackDoorBD40)
            : base(color, guarantee, WindowsType, isFrostedGlass, mainDoorPrice, backDoorPrice, isbackDoorBD60, isbackDoorBD40)
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
