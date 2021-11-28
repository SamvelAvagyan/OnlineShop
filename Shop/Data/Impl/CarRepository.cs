using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Impl
{
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        public CarRepository(ShopDBContext dbContext)
            : base(dbContext)
        { }

        public IQueryable GetAvailables()
        {
            return GetAll().Where(t => t.Available);
        }

        public async Task<IQueryable> GetAvailablesAsync()
        {
            return await Task.Run(() =>
            {
                return GetAvailables();
            });
        }

        public async Task<IQueryable<Car>> GetFavouriteCarsAsync()
        {
            return await Task.Run(() =>
            {
                return GetAll().Where(t => t.IsFavourite);
            });
        }
    }
}
