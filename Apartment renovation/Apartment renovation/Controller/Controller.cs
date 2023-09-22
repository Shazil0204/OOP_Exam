using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_renovation.Controller
{
    internal class Controller
    {

        CreatingApartment creatingApartment = new CreatingApartment();

        internal void MainController()
        {
            creatingApartment.AllApartments();
            Debug.WriteLine(creatingApartment.list._1RoomApartments.Count());
            Debug.WriteLine(creatingApartment.list._2RoomApartments.Count());
            Debug.WriteLine(creatingApartment.list._3RoomApartments.Count());
            Debug.WriteLine(creatingApartment.list._4RoomApartments.Count());
            Debug.WriteLine(creatingApartment.list._5RoomApartments.Count());
        }
    }
}
