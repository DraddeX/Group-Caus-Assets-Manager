using Group_Caus_Assests_Manager.Core.Entities;
using Group_Caus_Assests_Manager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Caus_Assests_Manager.Core.Services
{
    public class MockShiftService : IShiftService
    {
        public List<Shift> _shifts;
        public MockShiftService()
        {
            _shifts = [];
        }
        public Task<bool> AddShiftAsync(Shift shift)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteShiftAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Shift> GetShiftByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Shift>> GetShiftsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Shift>> GetShiftsByCarIdAsync(int carId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Shift>> GetShiftsByDateAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<List<Shift>> GetShiftsByDriverIdAsync(int driverId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateShiftAsync(Shift shift)
        {
            throw new NotImplementedException();
        }
    }
}
