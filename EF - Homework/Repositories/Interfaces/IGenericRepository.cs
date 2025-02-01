using EF___Homework.Entities.Common;

namespace EF___Homework.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity, new()
    {
        void Add(T entity);
        void Remove (T entity);
        T GetById(int id);
        List<T> GetAll();
        int Commit();

    }
}
