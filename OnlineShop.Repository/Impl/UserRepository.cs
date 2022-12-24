using OnlineShop.Repository.Models;
using System.Linq;

namespace OnlineShop.Repository.Impl
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        //public UserRepository(OnlineShopDbContext dbContext)
        //    : base(dbContext)
        //{ }

        public UserRepository()
            : base("user.json")
        { }

        public User GetByPhone(string phone)
        {
            phone = string.Concat('+', phone);
            return GetAll().FirstOrDefault(user => user.Phone == phone);
        }
    }
}
