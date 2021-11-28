using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        Task<IQueryable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T model);
        Task<bool> DeleteAsync(int id);
        Task UpdateAsync(T model);
    }
}
