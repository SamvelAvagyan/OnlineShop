using Shop.Data.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Impl
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        public Task AddAsync(T model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T model)
        {
            throw new NotImplementedException();
        }
    }
}
