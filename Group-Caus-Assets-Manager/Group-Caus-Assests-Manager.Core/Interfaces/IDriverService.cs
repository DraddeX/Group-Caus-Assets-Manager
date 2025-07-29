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
        Task<List<Driver>> GetDrivers();
        Task<Driver> GetDriverById(int id);
        Task<bool> AddDriver(Driver driver);
        Task<bool> UpdateDriver(Driver driver);
        Task<bool> DeleteDriver(int id);
    }   
}
