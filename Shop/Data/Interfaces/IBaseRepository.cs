using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<IQueryable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T model);
        Task DeleteAsync(int id);
        Task UpdateAsync(T model);
    }
}
