using CarStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.DL.Interfaces
{
    public interface ICarRepository
    {
        public void AddCar(Car car);


        public void DeleteCar(int id);

        public void UpdateCar(Car car);


        public Car? GetCar(int id);


        public List<Car> GetAllCars();

        public List<Car> GetAllCarsByBrand(int brandId);

    }
}
