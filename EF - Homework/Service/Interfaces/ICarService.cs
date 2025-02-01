using EF___Homework.Entities;

namespace EF___Homework.Service.Interfaces
{
    public interface ICarService
    {
        void Create(Car car);
        void Delete(int id);
        void Update(int id, Car car);
        Car GetById(int id);
        List<Car> GetAll();
    }
}
