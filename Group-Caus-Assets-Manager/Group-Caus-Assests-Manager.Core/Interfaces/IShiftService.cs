using Group_Caus_Assests_Manager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Caus_Assests_Manager.Core.Interfaces
{
    public interface IShiftService
    {
        Task<List<Shift>> GetShiftsAsync();
        Task<Shift> GetShiftByIdAsync(int id);
        Task<bool> AddShiftAsync(Shift shift);
        Task<bool> UpdateShiftAsync(Shift shift);
        Task<bool> DeleteShiftAsync(int id);
        Task<List<Shift>> GetShiftsByDateAsync(DateTime date);
        Task<List<Shift>> GetShiftsByDriverIdAsync(int driverId);
        Task<List<Shift>> GetShiftsByCarIdAsync(int carId);
    }
}
