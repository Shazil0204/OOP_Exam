using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apartment_renovation.Model.Classes;

namespace Apartment_renovation.Controller
{
    internal class Controller
    {
        CreatingApartment creatingApartment = new CreatingApartment();

        StandardApartment standardApartment = new StandardApartment();

        /// <summary>
        /// My main Controller
        /// </summary>
        internal void MainController()
        {
            // This will show the basic information about an apartment before renovetion
            Console.WriteLine(standardApartment.ToString());

            // This controller creates all my apartments
            creatingApartment.AllApartments();

            debugOutput();
        }

        /// <summary>
        /// This method will show how many apartments are there in my lists
        /// </summary>
        void debugOutput()
        {
            // Just to clarify that everything is happening exactly the way i want 
            Debug.WriteLine(creatingApartment.list._1RoomApartments.Count());
            Debug.WriteLine(creatingApartment.list._2RoomApartments.Count());
            Debug.WriteLine(creatingApartment.list._3RoomApartments.Count());
            Debug.WriteLine(creatingApartment.list._4RoomApartments.Count());
            Debug.WriteLine(creatingApartment.list._5RoomApartments.Count());
        }
    }
}
