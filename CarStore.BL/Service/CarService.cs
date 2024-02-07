using CarStore.BL.Interfaces;
using CarStore.DL.Interfaces;
using CarStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.BL.Service
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _CarRepository;

        public CarService(ICarRepository CarRepository)
        {
            _CarRepository = CarRepository;
        }
        public List<Car> GetAll()
        {
            return _CarRepository.GetAllCars();
        }

        public Car GetById(int id)
        {
            if (id <= 0) return new Car();

            return _CarRepository.GetCar(id);
        }

        public void Add(Car Car)
        {
            _CarRepository.AddCar(Car);
        }

        public void Remove(int id)
        {
            _CarRepository.DeleteCar(id);
        }
    }
}
