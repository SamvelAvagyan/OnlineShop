using System.Linq;

namespace OnlineShop.Repository
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        void Add(T model);
        void Update(T model);
    }
}
