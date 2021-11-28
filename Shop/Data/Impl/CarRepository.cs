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

        public async Task<IQueryable<Car>> GetFavouriteCarsAsync()
        {
            return await Task.Run(() =>
            {
                return GetAll().Where(t => t.IsFavourite);
            });
        }
    }
}
