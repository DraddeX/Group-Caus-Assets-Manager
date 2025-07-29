using Group_Caus_Assests_Manager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Caus_Assests_Manager.Core.Interfaces
{
    public interface ICarService
    {
        public List<Car> GetCars();
        public Car GetCarById(int id);
        public bool AddCar(Car car);
        public bool UpdateCar(Car car);
        public bool DeleteCar(int id);
    }
}
