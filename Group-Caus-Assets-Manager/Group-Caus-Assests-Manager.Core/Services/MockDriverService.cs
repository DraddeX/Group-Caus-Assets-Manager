using Group_Caus_Assests_Manager.Core.Entities;
using Group_Caus_Assests_Manager.Core.Interfaces;
using Group_Caus_Assests_Manager.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Caus_Assests_Manager.Core.Services
{
    public class MockDriverService : IDriverService
    {
        public DriverRepo _driverRepo;
        public MockDriverService()
        {
            _driverRepo = new();
        }
        public Task<bool> AddDriver(Driver driver)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDriver(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Driver> GetDriverById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Driver>> GetDrivers()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDriver(Driver driver)
        {
            throw new NotImplementedException();
        }
    }
}
