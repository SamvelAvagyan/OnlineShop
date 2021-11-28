using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Impl
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ShopDBContext dbContext) 
            : base(dbContext)
        { }
    }
}
