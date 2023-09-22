using System;
using System.Collections.Generic;
using Apartment_renovation.Model.Classes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apartment_renovation.Controller;

namespace Apartment_renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller.Controller controller = new Controller.Controller();
            controller.MainController();
        }
    }
}
