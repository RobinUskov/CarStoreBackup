using CarStore.BL.Interfaces;

namespace CarStore.BL.Service
{
    internal interface IBrandRepository
    {
        void Add(Brand brand);
        void Delete(int id);
        List<Brand> GetAll();
        Brand? GetById(int id);
    }
}