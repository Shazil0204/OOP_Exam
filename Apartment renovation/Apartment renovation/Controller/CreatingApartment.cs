using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Apartment_renovation.Model.Lists;
using Apartment_renovation.Model.Classes;
using Apartment_renovation.Model.Classes.Apartments;
using System.Diagnostics;

namespace Apartment_renovation.Controller
{
    internal class CreatingApartment
    {
    
        internal List list = new List();

        // taking all the fields from my TotalApartment Class and adding them into the for loop 
        private ushort _1room = TotalApartment._1RoomApartments;
        private byte _2room = TotalApartment._2RoomApartments;
        private byte _3room = TotalApartment._3RoomApartments;
        private byte _4room = TotalApartment._4RoomApartments;
        private byte _5room = TotalApartment._5RoomApartments;

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
            for (ushort i = 0; i < _1room; i++)
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
            for (byte i = 0; i < _2room; i++)
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
            for (byte i = 0; i < _3room; i++)
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
            for (byte i = 0; i < _4room; i++)
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
            for (byte i = 0; i < _5room; i++)
            {
                _5RoomApartment _5roomApartment = new _5RoomApartment(1, 1, 1, 5);

                list._5RoomApartments.Add(_5roomApartment);
            }
        }
    }
}
