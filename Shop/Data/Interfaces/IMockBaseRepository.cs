using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface IMockBaseRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}
