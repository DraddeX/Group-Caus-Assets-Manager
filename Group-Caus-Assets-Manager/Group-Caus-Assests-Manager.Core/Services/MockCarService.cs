using Group_Caus_Assests_Manager.Core.Entities;
using Group_Caus_Assests_Manager.Core.Interfaces;
using Group_Caus_Assests_Manager.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Group_Caus_Assests_Manager.Core.Services
{
    public class MockCarService : ICarService
    {
        public CarRepo _carRepo;
        public MockCarService()
        {
            _carRepo = new();
        }
        public async Task<bool> AddCar(Car car)
        {
            _carRepo._cars.Add(car);
            return _carRepo._cars.Contains(car) ? true : false;
        }

        public async Task<bool> DeleteCar(int id)
        {
            var car = GetCarById(id).Result;
            _carRepo._cars.Remove(car);
            return _carRepo._cars.Contains(car) ? false : true;
        }

        public async Task<Car> GetCarById(int id)
        {
            var car = _carRepo._cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                throw new KeyNotFoundException($"Car with ID {id} not found.");
            }
            return car;
        }

        public async Task<List<Car>> GetCars()
        {
            return _carRepo._cars;
        }

        public Task<bool> UpdateCar(Car car)
        {
            var existingCar = GetCarById(car.Id).Result;
            if (existingCar == null)
            {
                throw new KeyNotFoundException($"Car with ID {car.Id} not found.");
            }
            existingCar.Name = car.Name;
            existingCar.LicensePlate = car.LicensePlate;
            existingCar.IsAvailable = car.IsAvailable;
            existingCar.FuelState = car.FuelState;
            existingCar.Notes = car.Notes;
            return Task.FromResult(true);
        }
    }
}
