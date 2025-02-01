using EF___Homework.Entities;
using EF___Homework.PB503Exceptions;
using EF___Homework.Repositories.Interfaces;
using EF___Homework.Service.Interfaces;

namespace EF___Homework.Service.Implementations
{
    public class ModelService : IModelService
    {
        private readonly IModelRepository _modelRepository;

        public ModelService(IModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }

        public void Create(Model model)
        {
            if (model == null)
            {
                throw new EntityNotFoundException("Model cannot be null");
            }
            _modelRepository.Add(model);
            _modelRepository.Commit();
        }

        public void Delete(int id)
        {
            var model = _modelRepository.GetById(id);
            if (model is null)
            {
                throw new EntityNotFoundException("Model not found");
            }

            _modelRepository.Remove(model);
            _modelRepository.Commit();
        }

        public List<Model> GetAll()
        {
            var models = _modelRepository.GetAll()
                .Select(m => new Model
                {
                    Id = m.Id,
                    Name = m.Name,
                    BrandId = m.BrandId,
                    Brand = new Brand
                    {
                        Id = m.Brand.Id,
                        Name = m.Brand.Name
                    },
                    Cars = m.Cars.Select(car => new Car
                    {
                        Id = car.Id,
                        ModelId = car.ModelId,
                        MaxSpeed = car.MaxSpeed,
                        FuelTankCapacity = car.FuelTankCapacity,
                        Power = car.Power,
                        DoorCount = car.DoorCount
                    }).ToList()
                }).ToList();

            if (models.Count == 0)
                throw new EntityNotFoundException("No models found");

            return models;
        }

        public Model GetById(int id)
        {
            var model = _modelRepository.GetById(id);
            if (model is null)
            {
                throw new EntityNotFoundException("Model not found");
            }
            return model;
        }

        public void Update(int id, Model model)
        {
            var existingModel = _modelRepository.GetById(id);
            if (existingModel == null)
            {
                throw new EntityNotFoundException("Model not found");
            }

            existingModel.Name = model.Name;
            existingModel.BrandId = model.BrandId;
            _modelRepository.Commit();
        }
    }

}

