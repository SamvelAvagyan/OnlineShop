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

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (_productService.GetById(id) == null)
            {
                return NotFound($"There is no user with this id: {id}");
            }

            return Ok(_productService.GetById(id));
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            if (_productService.GetByName(name) == null)
            {
                return NotFound($"There is no user with this name: {name}");
            }

            return Ok(_productService.GetByName(name));
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

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public IActionResult Update([FromBody] ProductViewModelAdd productView)
        {
            ProductViewModelAddValidator validator = new ProductViewModelAddValidator();
            ValidationResult result = validator.Validate(productView);

            if (!result.IsValid)
            {
                return BadRequest(result.Errors);
            }

            ProductAddTransferModel productTransfer = _mapper.Map<ProductAddTransferModel>(productView);
            _productService.UpdateProduct(productTransfer);
            return Ok(productTransfer);
        }
    }
}
