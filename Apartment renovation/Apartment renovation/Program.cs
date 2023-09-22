using System;
using System.Collections.Generic;
using Apartment_renovation.Model.Classes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apartment_renovation.Controller;
using Apartment_renovation.Model.Lists;

namespace Apartment_renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller.Controller controller = new Controller.Controller();
            controller.MainController();

            int i = 0;
            foreach (var item in controller.creatingApartment.list._5RoomApartments.ToString())
            {
                i++;
                Console.WriteLine(i);
            }
        }
    }
}
