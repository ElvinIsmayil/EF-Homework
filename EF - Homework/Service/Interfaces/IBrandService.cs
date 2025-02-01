using EF___Homework.Entities;

namespace EF___Homework.Service.Interfaces
{
    public interface IBrandService
    {
        void Create(Brand brand);
        void Delete(int id);
        void Update(int id, Brand brand);
        Brand GetById(int id);
        List<Brand> GetAll();

    }
}
