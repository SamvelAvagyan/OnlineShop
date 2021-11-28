using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Impl
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : BaseModel
    {
        private readonly ShopDBContext _dbContext;

        public BaseRepository(ShopDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(T model)
        {
            _dbContext.Set<T>().Add(model);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var model = await GetByIdAsync(id);
            if (model == null)
                throw new ArgumentException("Invalid Id");
            _dbContext.Set<T>().Remove(model);
            return await _dbContext.SaveChangesAsync() == 1;
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            return await Task.Run(() =>
            {
                return _dbContext.Set<T>();
            });
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Task.Run(() =>
            {
                return GetById(id);
            });
        }

        public T GetById(int id)
        {
            return GetAll().FirstOrDefault(t => t.Id == id);
        }

        public async Task UpdateAsync(T model)
        {
            _dbContext.Set<T>().Update(model);
            await _dbContext.SaveChangesAsync();
        }
    }
}
