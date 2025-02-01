using EF___Homework.DTOs.Brand;
using EF___Homework.Entities;
using EF___Homework.PB503Exceptions;
using EF___Homework.Repositories.Interfaces;
using EF___Homework.Service.Interfaces;

namespace EF___Homework.Service.Implementations
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public void Create(BrandCreateDTO brandDto)
        {
            if (brandDto == null)
            {
                throw new EntityNotFoundException("Brand cannot be null");
            }
            if (string.IsNullOrWhiteSpace(brandDto.Name))
            {
                throw new Exception("Brand name cannot be null or empty");
            }

            Brand brand = new Brand() 
            {
                Name = brandDto.Name
            };
            _brandRepository.Add(brand);
            _brandRepository.Commit();
        }

        public void Delete(int id)
        {
            var brand = _brandRepository.GetById(id);
            if (brand is null)
            {
                throw new EntityNotFoundException("Brand not found");
            }

            _brandRepository.Remove(brand);
            _brandRepository.Commit();
        }

        public List<Brand> GetAll() 
        => _brandRepository.GetAll();

        public Brand GetById(int id)
        {
            var brand = _brandRepository.GetById(id);
            if (brand is null)
            {
                throw new EntityNotFoundException("Brand not found");
            }
            return brand;
        }

        public void Update(int id, Brand brand)
        {
            var existingBrand = _brandRepository.GetById(id);
            if (existingBrand == null)
            {
                throw new EntityNotFoundException("Brand not found");
            }

            existingBrand.Name = brand.Name;
            _brandRepository.Commit();
        }

    }

}

