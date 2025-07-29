using Group_Caus_Assests_Manager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Caus_Assests_Manager.Core.Interfaces
{
    public interface IDriverService
    {
        public List<Driver> GetDrivers();
        public Driver GetDriverById(int id);
        public bool AddDriver(Driver driver);
        public bool UpdateDriver(Driver driver);
        public bool DeleteDriver(int id);
    }
}
