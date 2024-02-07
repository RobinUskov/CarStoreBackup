using CarStore.BL.Interfaces;
using CarStore.BL.Service;
using CarStore.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost("Add")]
        public void AddCar([FromBody] Car Car)
        {
            _carService.Add(Car);
        }

        [HttpDelete("Delete")]
        public void DeleteCar(int id)
        {
            _carService.Remove(id);
        }


        [HttpGet("GetById")]
        public Car? GetCar(int id)
        {
            return _carService.GetById(id);
        }

        [HttpGet("GetAllCars")]
        public List<Car> GetAll()
        {
            return _carService.GetAll();
        }
    }
}
