using AutoMapper;
using OnlineShop.Repository;
using OnlineShop.Repository.Models;
using OnlineShop.Service.DataTransferModels;

namespace OnlineShop.Service.Impl
{
    public class ProductService : BaseService<Product>, IProductService
    {
        private readonly IMapper _mapper;

        public ProductService(IBaseRepository<Product> baseRepository, IMapper mapper)
            : base(baseRepository)
        {
            _mapper = mapper;
        }

        public void AddProduct(ProductAddTransferModel productTransfer)
        {
            Product product = _mapper.Map<Product>(productTransfer);
            base.Add(product);
        }

        public void UpdateProduct(ProductAddTransferModel productTransfer)
        {
            Product product = _mapper.Map<Product>(productTransfer);
            base.Update(product);
        }
    }
}
