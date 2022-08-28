using OnlineShop.Repository;
using System.Linq;

namespace OnlineShop.Service.Impl
{
    public class BaseService<T> : IBaseService<T>
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Add(T model)
        {
            _baseRepository.Add(model);
        }

        public IQueryable<T> GetAll() 
        {
            return _baseRepository.GetAll();
        }
    }
}
