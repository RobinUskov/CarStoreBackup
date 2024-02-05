using CarStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.DL.Interfaces
{
     public interface IBrandRepository
    {
        public void AddBrand(Brand brand);


        public void DeleteBrand(int id);

        public void UpdateBrand(Brand brand);


        public Brand? GetBrand(int id);


        public List<Brand> GetAllBrands();
    }
}
