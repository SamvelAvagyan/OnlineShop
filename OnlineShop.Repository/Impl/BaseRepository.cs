using System.Linq;

namespace OnlineShop.Repository.Impl
{
    public class BaseRepository<T> : IBaseRepository<T> 
        where T : class
    {
        private readonly OnlineShopDbContext _dbContext;

        public BaseRepository(OnlineShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T model)
        {
            _dbContext.Set<T>().Add(model);
            _dbContext.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }
    }
}
