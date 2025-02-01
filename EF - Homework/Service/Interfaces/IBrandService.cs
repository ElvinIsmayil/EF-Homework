using EF___Homework.DTOs.Brand;
using EF___Homework.Entities;

namespace EF___Homework.Service.Interfaces
{
    public interface IBrandService
    {
        void Create(BrandCreateDTO brandDTO);
        void Delete(int id);
        void Update(int id, Brand brand);
        Brand GetById(int id);
        List<Brand> GetAll();

    }
}
