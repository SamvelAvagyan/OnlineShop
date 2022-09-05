using AutoMapper;
using OnlineShop.Repository;
using OnlineShop.Repository.Models;
using OnlineShop.Service.DataTransferModels;

namespace OnlineShop.Service.Impl
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        private readonly IMapper _mapper;

        public CategoryService(IBaseRepository<Category> baseRepository, IMapper mapper)
            : base(baseRepository)
        {
            _mapper = mapper;
        }

        public void AddCategory(CategoryAddTransferModel categoryTransfer)
        {
            Category category = _mapper.Map<Category>(categoryTransfer);
            base.Add(category);
        }
    }
}
