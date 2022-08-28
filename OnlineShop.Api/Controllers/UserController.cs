using AutoMapper;
using OnlineShop.Api.Validations;
using OnlineShop.Api.ViewModels;
using OnlineShop.Service;
using OnlineShop.Service.DataTransferModels;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }

        [HttpPost("register")]
        public IActionResult Register(UserViewModelRegister userView)
        {
            UserViewModelRegisterValidator validator = new UserViewModelRegisterValidator();
            ValidationResult result = validator.Validate(userView);

            if (!result.IsValid)
            {
                return BadRequest(result.Errors);
            }

            UserRegisterTransferModel user = mapper.Map<UserRegisterTransferModel>(userView);
            _userService.Register(user);
            return Ok(user);
        }

        [HttpGet("authorize")]
        [Authorize]
        public IActionResult AuthorizedMethod()
        {
            return Ok("You are already logged in!");
        }
    }
}
