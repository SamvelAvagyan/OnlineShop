using OnlineShop.Repository.Models;
using OnlineShop.Service.DataTransferModels;

namespace OnlineShop.Service
{
    public interface IUserService : IBaseService<User>
    {
        User GetByPhone(string phone);
        void Register(UserRegisterTransferModel userTransfer);
        User Login(UserLoginTransferModel userTransfer);
    }
}
