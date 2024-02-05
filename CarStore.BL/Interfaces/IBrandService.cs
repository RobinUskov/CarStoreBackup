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
        List<Brand> GetAll();

        Brand? GetById(int id);

        void Add(Brand author);

        void Delete(int id);
    }
}
