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

        protected Apartment(int livingroom, int kitchen, int bathroom, int room) 
        {
            this.livingroom = livingroom;
            this.kitchen = kitchen;
            this.bathroom = bathroom;
            this.room = room;
        }

        #endregion
    }
}
