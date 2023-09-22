using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Apartment_renovation.Model.Lists;
using Apartment_renovation.Model.Classes.Apartments;

namespace Apartment_renovation.Controller
{
    internal class CreatingApartment
    {
    
        List list = new List();

        /// <summary>
        /// all methods are combine
        /// </summary>
        internal void AllApartments()
        {
            Apartment1();
            Apartment2();
            Apartment3();
            Apartment4();
            Apartment5();
        }

        /// <summary>
        /// create 368 1 room apartments
        /// </summary>
        void Apartment1()
        {
            for (ushort i = 0; i <= 368; i++)
            {
                _1RoomApartment _1roomApartment = new _1RoomApartment(1, 1, 1, 1);

                list._1RoomApartments.Add(_1roomApartment);
            }
        }

        /// <summary>
        /// create 2 room apartments
        /// </summary>
        void Apartment2()
        {
            for (byte i = 0; i <= 235; i++)
            {
                _2RoomApartment _2roomApartment = new _2RoomApartment(1, 1, 1, 2);

                list._2RoomApartments.Add(_2roomApartment);
            }
        }

        /// <summary>
        /// create 3 room apartments
        /// </summary>
        void Apartment3()
        {
            for (byte i = 0; i <= 167; i++)
            {
                _3RoomApartment _3roomApartment = new _3RoomApartment(1, 1, 1, 3);

                list._3RoomApartments.Add(_3roomApartment);
            }
        }

        /// <summary>
        /// create 4 room apartments
        /// </summary>
        void Apartment4()
        {
            for (byte i = 0; i <= 97; i++)
            {
                _4RoomApartment _4roomApartment = new _4RoomApartment(1, 1, 1, 4);
                
                list._4RoomApartments.Add(_4roomApartment);
            }
        }

        /// <summary>
        /// create 5 room apartments
        /// </summary>
        void Apartment5()
        {
            for (byte i = 0; i <= 47; i++)
            {
                _5RoomApartment _5roomApartment = new _5RoomApartment(1, 1, 1, 5);

                list._5RoomApartments.Add(_5roomApartment);
            }
        }
    }
}
