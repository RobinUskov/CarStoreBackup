using CarStore.BL.Interfaces;
using CarStore.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost("Add")]
        public void AddBrand([FromBody] Brand brand)     
        {
            _brandService.Add(brand);
        }

        [HttpDelete("Delete")]
        public void DeleteBrand(int id)
        {
            _brandService.Delete(id);
        }


        [HttpGet("GetById")]
        public Brand? GetBrand(int id)
        {
            return _brandService.GetById(id);
        }

        [HttpGet("GetAllBrands")]
        public List<Brand> GetAll()
        {
            return _brandService.GetAll();
        }



    }
}
