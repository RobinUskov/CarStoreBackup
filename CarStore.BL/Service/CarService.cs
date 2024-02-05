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
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<Car> GetAllCarsByBrand(int brandId)
        {
            return _carRepository.GetAllCarsByBrand(brandId);
        }
    }
}
