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
        public List<Shift> GetShifts();
        public Shift GetShiftById(int id);
        public bool AddShift(Shift shift);
        public bool UpdateShift(Shift shift);
        public bool DeleteShift(int id);
        public List<Shift> GetShiftsByDate(DateTime date);
        public List<Shift> GetShiftsByDriverId(int driverId);
        public List<Shift> GetShiftsByCarId(int carId);
        public TimeSpan CalculateTotalDuration(List<Shift> shifts);
    }
}
