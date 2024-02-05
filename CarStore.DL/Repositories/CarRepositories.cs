using CarStore.DL.InMemoryDb;
using CarStore.DL.Interfaces;
using CarStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.DL.Repositories
{
    public class CarRepository : ICarRepository
    {
        public void AddCar(Car car)
        {
            StaticData.Cars.Add(car);
        }

        public void DeleteCar(int id)
        {
            var car = StaticData.Cars.FirstOrDefault(b => b.Id == id);
            if (car == null) return;
            StaticData.Cars.Remove(car);
        }

        public List<Car> GetAllCars()
        {
            return StaticData.Cars;
        }

        public List<Car> GetAllCarsByBrand(int brandId)
        {
            return InMemoryDb.StaticData.Cars
                    .Where(b => b.BrandId == brandId)
                    .ToList();
        }

        public Car? GetCar(int id)
        {
            return StaticData.Cars.FirstOrDefault(b => b.Id == id);
        }

        public void UpdateCar(Car car)
        {
            var existingCar = StaticData.Cars.FirstOrDefault(b => b.Id == car.Id);
            if (existingCar == null) return;

            StaticData.Cars.Remove(existingCar);

            StaticData.Cars.Add(new Car()
            {
                Id = existingCar.Id,
                Model = car.Model,
            });
        }
    }
}
