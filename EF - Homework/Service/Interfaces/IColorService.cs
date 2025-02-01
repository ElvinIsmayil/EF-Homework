using EF___Homework.Entities;

namespace EF___Homework.Service.Interfaces
{
    public interface IColorService
    {
        void Create(Color color);
        void Delete(int id);
        void Update(int id, Color color);
        Color GetById(int id);
        List<Color> GetAll();
    }
}
