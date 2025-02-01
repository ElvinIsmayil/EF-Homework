using EF___Homework.Entities;
using EF___Homework.Repositories.Interfaces;

namespace EF___Homework.Repositories.Implementations
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
    }
}
