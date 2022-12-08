using System.Linq;

namespace OnlineShop.Service
{
    public interface IBaseService<T>
    {
        IQueryable<T> GetAll();
        void Add(T model);
        void Update(T model);
    }
}
