using AutoMapper;
using OnlineShop.Repository.Models;
using OnlineShop.Service.DataTransferModels;

namespace OnlineShop.Service.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddTransferModel, Category>();
        }
    }
}
