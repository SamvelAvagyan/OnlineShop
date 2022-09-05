using OnlineShop.Repository.Models;

namespace OnlineShop.Repository.Impl
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(OnlineShopDbContext dbContext) 
            : base(dbContext)
        { }


    }
}
