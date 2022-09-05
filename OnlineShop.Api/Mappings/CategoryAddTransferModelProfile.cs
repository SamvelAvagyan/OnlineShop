using AutoMapper;
using OnlineShop.Api.ViewModels;
using OnlineShop.Service.DataTransferModels;

namespace OnlineShop.Api.Mappings
{
    public class CategoryAddTransferModelProfile : Profile
    {
        public CategoryAddTransferModelProfile()
        {
            CreateMap<CategoryViewModelAdd, CategoryAddTransferModel>();
        }
    }
}
