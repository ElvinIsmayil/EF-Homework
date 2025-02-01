using EF___Homework.Entities;

namespace EF___Homework.Service.Interfaces
{
    public interface IModelService
    {
        void Create(Model model);
        void Delete(int id);
        void Update(int id, Model model);
        Model GetById(int id);
        List<Model> GetAll();
    }
}
