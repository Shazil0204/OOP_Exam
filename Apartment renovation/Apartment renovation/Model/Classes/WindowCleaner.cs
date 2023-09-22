using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_renovation.Model.Classes
{
    internal abstract class WindowCleaner
    {
        #region fields

        protected string color;
        protected string guarantee;
        protected string WindowsType;
        protected bool isFrostedGlass;
        protected ushort mainDoorPrice;
        protected ushort backDoorPrice;
        protected byte backDoorBD60;
        protected byte backDoorBD40;

        #endregion

        #region constructor

        protected WindowCleaner(string color, string guarantee, string WindowsType, bool isFrostedGlass, ushort mainDoorPrice, ushort backDoorPrice, byte backDoorBD60, byte backDoorBD40)
        {
            this.color = color;
            this.guarantee = guarantee;
            this.WindowsType = WindowsType;
            this.isFrostedGlass = isFrostedGlass;
            this.mainDoorPrice = mainDoorPrice;
            this.backDoorPrice = backDoorPrice;
            this.backDoorBD60 = backDoorBD60;
            this.backDoorBD40 = backDoorBD40;
        }

        #endregion

        #region tostring

        public override string ToString()
        {
            return $"The Color of the Glass is ";
        }

        #endregion
    }
}
