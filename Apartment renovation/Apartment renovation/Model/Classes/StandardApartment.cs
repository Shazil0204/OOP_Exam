using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_renovation.Model.Classes
{
    internal class StandardApartment
    {
        // All my fields for this class
        #region field
        private const bool _sharing_Friendly    = true;
        private const bool _washingMachine      = false;
        private const bool _seniorFriendly      = true;
        private const bool _chargingStand       = false;
        private const bool _studentsOnly        = false;
        private const bool _petsAllowed         = false;
        private const char _energyLabel         = 'D';
        private const bool _dishwasher          = false;
        private const bool _furnished           = false;
        private const bool _elevator            = true;
        private const bool _balcony             = true;
        private const bool _parking             = true;
        private const bool _dryer               = false;
        #endregion

        // My tostring method show all my fields:
        #region tostring

        public override string ToString()
        {
            return 
                $"Here is everything that you will need to know about the apartment:\n" +
                $"1. Can you share your apartment {_sharing_Friendly}\n" +
                $"2. Is apartment only for students {_studentsOnly}\n" +
                $"3. Is apartment useable for elders {_seniorFriendly}\n" +
                $"4. Does apartment have an Elevator {_elevator}\n" +
                $"5. Does apartment have a parking lot {_parking}\n" +
                $"6. Does apartment have a balcony {_balcony}\n" +
                $"7. Does apartment have furnicher {_furnished}\n" +
                $"8. Does apartment allow pets {_petsAllowed}\n" +
                $"9. Does apartment have a charging stánd {_chargingStand}\n" +
                $"10. Does apartment have a washing machine {_washingMachine}\n" +
                $"11. Does apartment have a dish washer {_dishwasher}\n" +
                $"12. Does apartment have a dryer {_dryer}\n" +
                $"13. Apartment enerygy Label \"{_energyLabel}\"\n";
        }

        #endregion
    }
}
