using CarStore.BL.Interfaces;
using CarStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return _brandRepository.GetAll();
        }

        public Brand? GetById(int id)
        {
            if (id <= 0) return null;

            return _brandRepository.GetById(id);
        }

        public void Add(Brand brand)
        {
            _brandRepository.Add(brand);
        }

        public void Delete(int id)
        {
            _brandRepository.Delete(id);
        }

        List<Brand> IBrandService.GetAll()
        {
            throw new NotImplementedException();
        }

        Brand? IBrandService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Brand author)
        {
            throw new NotImplementedException();
        }
    }
}
