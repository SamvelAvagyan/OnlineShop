using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        IEnumerable<Car> GetFavouriteCars();
        Car GetCar(int id);
    }
}
