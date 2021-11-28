using Shop.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        Task<IQueryable<Car>> GetFavouriteCarsAsync();
    }
}
