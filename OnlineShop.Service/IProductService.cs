using OnlineShop.Repository.Models;
using OnlineShop.Service.DataTransferModels;

namespace OnlineShop.Service
{
    public interface IProductService : IBaseService<Product>
    {
        void AddProduct(ProductAddTransferModel productTransfer);
    }
}
