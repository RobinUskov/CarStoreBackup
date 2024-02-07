using CarStore.BL.Interfaces;
using CarStore.Models.Models;
using CarStore.DL.Interfaces;

namespace CarStore.BL.Service
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public List<Brand> GetAll()
        {
            return _brandRepository.GetAllBrands();
        }

        public Brand? GetById(int id)
        {
            if (id <= 0) return null;

            return _brandRepository.GetBrand(id);
        }

        public void Add(Brand brand)
        {
            _brandRepository.AddBrand(brand);
        }

        public void Delete(int id)
        {
            _brandRepository.DeleteBrand(id);
        }
    }
}
