using OnlineShop.Repository.Models;

namespace OnlineShop.Repository.Impl
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(OnlineShopDbContext dbContext)
           : base(dbContext)
        { }
    }
}
