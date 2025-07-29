using Group_Caus_Assests_Manager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Caus_Assests_Manager.Core.Repositories
{
    public class DriverRepo
    {
        public List<Driver> _drivers;
        public DriverRepo()
        {
            _drivers =
            [
                new Driver(1, "Lore", "De Smedt"),
                new Driver(2, "Cammille", "Van De Broeck"),
                new Driver(3, "Janne", "Peeters"),
                new Driver(4, "Louise", "Vandenberghe"),
                new Driver(5, "Kobe", "Maes"),
                new Driver(6, "Vic", "De Vos"),
                new Driver(7, "Tuur", "Van Damme"),
                new Driver(8, "Emiel", "D'Hondt"),
            ];
        }
    }
}
