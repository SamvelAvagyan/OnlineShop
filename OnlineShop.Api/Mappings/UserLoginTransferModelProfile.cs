using AutoMapper;
using OnlineShop.Api.ViewModels;
using OnlineShop.Service.DataTransferModels;

namespace OnlineShop.Api.Mappings
{
    public class UserLoginTransferModelProfile : Profile
    {
        public UserLoginTransferModelProfile()
        {
            CreateMap<UserViewModelLogin, UserLoginTransferModel>();
        }
    }
}
