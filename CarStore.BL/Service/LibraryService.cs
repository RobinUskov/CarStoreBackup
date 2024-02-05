using CarStore.BL.Interfaces;
using CarStore.Models.Requests;
using CarStore.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.BL.Service
{
    public class LibraryService : ILibraryService
    {
        private readonly ICarService _carService;
        private readonly IBrandService _brandService;

        public LibraryService(
            ICarService carService,
            IBrandService brandService)
        {
            _carService = carService;
            _brandService = brandService;
        }

        public GetAllCarsByBrandResponse?
            GetAllCarsByBrandAfterDate(
                GetAllCarsByBrandRequest request)
        {
            var cars = _carService
                .GetAllCarsByBrand(request.BrandId);

            var brand = _brandService
                .GetById(request.BrandId);

            if (brand == null) return null;

            var result = new GetAllCarsByBrandResponse
            {
                Brand = brand, //Get author
                Cars = cars
                    .Where(b =>
                        b.ReleaseDate >= request.AfterDate)
                    .ToList()
            };

            return result;
        }

        public int GetAllCarsCount(int inputCount, int brandId)
        {
            if (inputCount <= 0) return 0;

            var result = _carService.GetAllCarsByBrand(brandId);

            return result.Count + inputCount;
        }
    }
}
