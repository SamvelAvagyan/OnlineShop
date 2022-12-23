using OnlineShop.Repository;
using OnlineShop.Repository.Models;
using System.Linq;

namespace OnlineShop.Service.Impl
{
    public class OrderService : BaseService<Order>, IOrderService
    {
        public OrderService(IBaseRepository<Order> baseRepository)
            : base(baseRepository)
        { }

        public Order GetById(int id)
        {
            return base.GetAll().FirstOrDefault(order => order.Id == id);
        }
    }
}
