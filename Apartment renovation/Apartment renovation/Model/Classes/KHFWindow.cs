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
        internal KHFWindow(string color, string guarantee, string WindowsType, bool isFrostedGlass, ushort mainDoorPrice, ushort backDoorPrice, byte backDoorBD60, byte backDoorBD40)
            : base(color, guarantee, WindowsType, isFrostedGlass, mainDoorPrice, backDoorPrice, backDoorBD60, backDoorBD40)
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
