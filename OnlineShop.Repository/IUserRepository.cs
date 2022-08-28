using OnlineShop.Repository.Models;

namespace OnlineShop.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetByPhone(string phone);
    }
}
