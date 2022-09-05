using OnlineShop.Repository.Models;
using OnlineShop.Service.DataTransferModels;

namespace OnlineShop.Service
{
    public interface ICategoryService : IBaseService<Category>
    {
        void AddCategory(CategoryAddTransferModel categoryTransfer);
    }
}
