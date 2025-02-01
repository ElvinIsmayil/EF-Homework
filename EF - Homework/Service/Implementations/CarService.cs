using EF___Homework.Entities;
using EF___Homework.PB503Exceptions;
using EF___Homework.Repositories.Interfaces;
using EF___Homework.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EF___Homework.Service.Implementations
{
   
        public class CarService : ICarService
        {
            private readonly ICarRepository _carRepository;

            public CarService(ICarRepository carRepository)
            {
                _carRepository = carRepository;
            }

            public void Create(Car car)
            {
                if (car == null)
                {
                    throw new EntityNotFoundException("Car cannot be null");
                }
                _carRepository.Add(car);
                _carRepository.Commit();
            }

            public void Delete(int id)
            {
                var car = _carRepository.GetById(id);
                if (car is null)
                {
                    throw new EntityNotFoundException("Car not found");
                }

                _carRepository.Remove(car);
                _carRepository.Commit();
            }


        public List<Car> GetAll()
        {
            var cars = _carRepository.GetAll()
                .Select(c => new Car
                {
                    Id = c.Id,
                    ModelId = c.ModelId,
                    Model = new Model
                    {
                        Id = c.Model.Id,
                        Name = c.Model.Name,
                        Brand = new Brand
                        {
                            Id = c.Model.Brand.Id,
                            Name = c.Model.Brand.Name
                        }
                    },
                    CarColors = c.CarColors.Select(cc => new CarColor
                    {
                        Id = cc.Id,
                        Color = new Color
                        {
                            Id = cc.Color.Id,
                            Name = cc.Color.Name
                        }
                    }).ToList(),
                    MaxSpeed = c.MaxSpeed,
                    FuelTankCapacity = c.FuelTankCapacity,
                    Power = c.Power,
                    DoorCount = c.DoorCount
                }).ToList();

            if (cars.Count == 0)
                throw new EntityNotFoundException("No cars found");

            return cars;
        }

        public Car GetById(int id)
            {
                var car = _carRepository.GetById(id);
                if (car is null)
                {
                    throw new EntityNotFoundException("Car not found");
                }
                return car;
            }

        public void Update(int id, Car car)
        {
            if (car == null)
            {
                throw new EntityNotFoundException("Car data cannot be null");
            }

            var existingCar = _carRepository.GetById(id);
            if (existingCar == null)
            {
                throw new EntityNotFoundException("Car not found");
            }

            existingCar.ModelId = car.ModelId;
            existingCar.MaxSpeed = car.MaxSpeed;
            existingCar.FuelTankCapacity = car.FuelTankCapacity;
            existingCar.Power = car.Power;
            existingCar.DoorCount = car.DoorCount;
            _carRepository.Commit();
        }
    }
    }
