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
    public class BrandRepository : IBrandRepository
    {
        public void AddBrand(Brand brand)
        {
            StaticData.Brands.Add(brand);
        }

        public void DeleteBrand(int id)
        {
            var brand = StaticData.Brands.FirstOrDefault(a => a.Id == id);
            if (brand == null) return;
            StaticData.Brands.Remove(brand);
        }

        public List<Brand> GetAllBrands()
        {
            return StaticData.Brands;
        }

        public Brand? GetBrand(int id)
        {
            return StaticData.Brands.FirstOrDefault(a => a.Id == id);
        }

        public void UpdateBrand(Brand brand)
        {
            var existingBrand = StaticData.Brands.FirstOrDefault(a => a.Id == brand.Id);
            if (existingBrand == null) return;

            StaticData.Brands.Remove(existingBrand);

            StaticData.Brands.Add(new Brand()
            {
                Id = existingBrand.Id,
                Name = brand.Name,
                Bio = brand.Bio,
            });
        }
    }
}
