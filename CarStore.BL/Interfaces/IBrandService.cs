using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStore.Models.Models;

namespace CarStore.BL.Interfaces
{
    public interface IBrandService
    {
        public List <Brand> GetAll();

        public Brand? GetById(int id);

        public void Add(Brand brand);

        public void Delete(int id);
       
    }
}
