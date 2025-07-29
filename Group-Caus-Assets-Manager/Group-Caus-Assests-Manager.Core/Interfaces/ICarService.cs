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
        List<Car> GetCars();
        Car GetCarById(int id);
        Task<bool> AddCar(Car car);
        Task<bool> UpdateCar(Car car);
        Task<bool> DeleteCar(int id);
    }
}
