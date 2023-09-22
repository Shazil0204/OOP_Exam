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
        protected bool isbackDoorBD60;
        protected bool isbackDoorBD40;

        #endregion

        #region constructor

        protected WindowCleaner(string color, string guarantee, string WindowsType, bool isFrostedGlass, ushort mainDoorPrice, ushort backDoorPrice, bool isbackDoorBD60, bool isbackDoorBD40)
        {
            this.color = color;
            this.guarantee = guarantee;
            this.WindowsType = WindowsType;
            this.isFrostedGlass = isFrostedGlass;
            this.mainDoorPrice = mainDoorPrice;
            this.backDoorPrice = backDoorPrice;
            this.isbackDoorBD60 = isbackDoorBD60;
            this.isbackDoorBD40 = isbackDoorBD40;
        }

        #endregion

        #region tostring

        public override string ToString()
        {
            return 
                $"Color: {this.color}\n" +
                $"Guarantee: {this.guarantee}\n" +
                $"Windows Type: {this.WindowsType}\n" +
                $"Is Frosted Glass: {this.isFrostedGlass}\n" +
                $"Main Door Prise: {this.mainDoorPrice}\n" +
                $"Back Door Price: {this.backDoorPrice}\n" +
                $"Is Back Door BD60: {this.isbackDoorBD60}\n" +
                $"Is Back Door BD40: {this.isbackDoorBD40}\n";
        }

        #endregion
    }
}
