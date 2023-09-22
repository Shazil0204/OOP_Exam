using Apartment_renovation.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Apartment_renovation.Model.Classes
{
    internal class TotalApartment: ITotalApartments
    {
        internal const ushort _1RoomApartments = 368;
        internal const byte _2RoomApartments = 235;
        internal const byte _3RoomApartments = 167;
        internal const byte _4RoomApartments = 97;
        internal const byte _5RoomApartments = 47;
        private ushort _totalApartmentInDenmark = 0;

        public int Count()
        {
            _totalApartmentInDenmark = (_1RoomApartments + _2RoomApartments + _3RoomApartments + _4RoomApartments + _5RoomApartments);

            return _totalApartmentInDenmark;
        }

        public override string ToString()
        {
            return $"There are a total of {Count()} apartments in whole denmark;";
        }
    }
}
