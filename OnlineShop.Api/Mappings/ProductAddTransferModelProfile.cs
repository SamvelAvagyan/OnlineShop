using AutoMapper;
using OnlineShop.Api.ViewModels;
using OnlineShop.Service.DataTransferModels;

namespace OnlineShop.Api.Mappings
{
    public class ProductAddTransferModelProfile : Profile
    {
        public ProductAddTransferModelProfile()
        {
            CreateMap<ProductViewModelAdd, ProductAddTransferModel>();
        }
    }
}
