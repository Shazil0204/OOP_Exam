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
        protected string livingroom;
        protected string kitchen;
        protected string bathroom;
        protected string room;
        #endregion

        #region constructor

        protected Apartment(string livingroom, string kitchen, string bathroom, string room) 
        {
            this.livingroom = livingroom;
            this.kitchen = kitchen;
            this.bathroom = bathroom;
            this.room = room;
        }

        #endregion
    }
}
