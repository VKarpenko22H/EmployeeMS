using DataAccess.Entities;

namespace DataAccess.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById<IdType>(IdType id);

        
        IEnumerable<T> Create(T t);
        

    }
}

