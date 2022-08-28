using AutoMapper;
using OnlineShop.Repository;
using OnlineShop.Repository.Models;
using OnlineShop.Service.DataTransferModels;
using System;

namespace OnlineShop.Service.Impl
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IBaseRepository<User> baseRepository, IUserRepository userRepository, IMapper mapper)
            : base(baseRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public User GetByPhone(string phone)
        {
            return _userRepository.GetByPhone(phone);
        }

        public User Login(UserLoginTransferModel userTransfer)
        {
            User user = GetByPhone(userTransfer.Phone);

            if (user != null && HashManager.VerifyHashedPassword(user.Password, userTransfer.Password))
            {
                return user;
            }
            else
            {
                throw new Exception("Phone number or password is incorrect");
            }
        }

        public void Register(UserRegisterTransferModel userTransfer)
        {
            if (userTransfer.ConfirmPassword != userTransfer.Password)
            {
                throw new Exception("Password must be equal to Confirm Password");
            }

            if (GetByPhone(userTransfer.Phone) != null)
            {
                throw new Exception("There is already a User with this phone number");
            }

            userTransfer.Phone = string.Concat('+', userTransfer.Phone);
            userTransfer.Password = HashManager.HashPassword(userTransfer.Password);
            User user = _mapper.Map<User>(userTransfer);
            Add(user);
        }
    }
}
