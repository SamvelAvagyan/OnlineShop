using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface IMockCarRepository : IMockBaseRepository<Car>
    {
        IEnumerable<Car> GetFavouriteCars();
        Car GetCar(int id);
    }
}
