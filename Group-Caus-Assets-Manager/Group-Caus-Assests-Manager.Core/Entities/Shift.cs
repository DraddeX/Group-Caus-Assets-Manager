using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Caus_Assests_Manager.Core.Entities
{
    public class Shift
    {
        public Shift(Car car, Driver driver, DateTime startTime, DateTime endTime)
        {
            Car = car;
            Driver = driver;
            StartTime = startTime;
            EndTime = endTime;
        }
        public Car Car { get; set; }
        public Driver Driver { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
