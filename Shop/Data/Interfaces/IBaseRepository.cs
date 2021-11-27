using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}
