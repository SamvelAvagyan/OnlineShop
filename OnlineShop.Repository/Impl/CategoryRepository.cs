using OnlineShop.Repository.Models;

namespace OnlineShop.Repository.Impl
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(OnlineShopDbContext dbContext)
           : base(dbContext)
        { }
    }
}
