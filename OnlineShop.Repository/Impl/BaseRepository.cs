using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace OnlineShop.Repository.Impl
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        //private readonly OnlineShopDbContext _dbContext;
        private readonly string dataPath;

        public BaseRepository(string dataPath)
        {
            this.dataPath = dataPath;
        }

        //public BaseRepository(OnlineShopDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public void Add(T model)
        {
            using (FileStream fs = new FileStream(dataPath, FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync<T>(fs, model);
            }
            //_dbContext.Set<T>().Add(model);
            //_dbContext.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> data = JsonSerializer.Deserialize<IQueryable<T>>(dataPath);
            return data;
            //return _dbContext.Set<T>();
        }

        public void Update(T model)
        {
            //_dbContext.Set<T>().Update(model);
            //_dbContext.SaveChanges();
        }
    }
}
