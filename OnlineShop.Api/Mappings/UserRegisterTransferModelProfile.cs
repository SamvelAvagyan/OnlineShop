using AutoMapper;
using OnlineShop.Api.ViewModels;
using OnlineShop.Service.DataTransferModels;

namespace OnlineShop.Api.Mappings
{
    public class UserRegisterTransferModelProfile : Profile
    {
        public UserRegisterTransferModelProfile()
        {
            CreateMap<UserViewModelRegister, UserRegisterTransferModel>();
        }
    }
}
