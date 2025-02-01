using EF___Homework.DataAccess.Data;
using EF___Homework.Entities.Common;
using EF___Homework.Repositories.Interfaces;

namespace EF___Homework.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepository()
        =>  _appDbContext = new AppDbContext();
        

        public void Add(T entity)
            => _appDbContext.Set<T>().Add(entity);
        

        public int Commit()
        =>  _appDbContext.SaveChanges();
        

        public List<T> GetAll()
        => _appDbContext.Set<T>().ToList(); 

        public T GetById(int id)
        => _appDbContext.Set<T>().FirstOrDefault(x=>x.Id==id);

        public void Remove(T entity)
            => _appDbContext.Set<T>().Remove(entity);
       
    }
}
