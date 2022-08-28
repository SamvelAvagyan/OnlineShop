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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }

        [HttpPost]
        [Authorize(Roles="Admin")]
        public IActionResult Add([FromBody]ProductViewModelAdd productView)
        {
            ProductViewModelAddValidator validator = new ProductViewModelAddValidator();
            ValidationResult result = validator.Validate(productView);

            if (!result.IsValid)
            {
                return BadRequest(result.Errors);
            }

            ProductAddTransferModel productTransfer = _mapper.Map<ProductAddTransferModel>(productView);
            _productService.AddProduct(productTransfer);
            return Ok(productTransfer);
        }
    }
}
