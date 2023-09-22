using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_renovation.Model.Classes
{
    internal abstract class Apartment
    {
        #region fields
        protected int livingroom;
        protected int kitchen;
        protected int bathroom;
        protected int room;
        #endregion

        #region constructor

        protected Apartment(int livingroom, int kitchen, int bathroom)
        {
            this.livingroom = livingroom;
            this.kitchen = kitchen;
            this.bathroom = bathroom;
        }

        protected Apartment(int livingroom, int kitchen, int bathroom, int room) : this(livingroom, kitchen, bathroom)
        { 
            this.room = room;
        }

        public override string ToString()
        {
            return 
                $"Livingroom: {this.livingroom}\n" +
                $"Kitchen: {this.kitchen}\n" +
                $"Bathroom: {this.bathroom}\n" +
                $"Room: {this.room}\n";
        }

        #endregion
    }
}
