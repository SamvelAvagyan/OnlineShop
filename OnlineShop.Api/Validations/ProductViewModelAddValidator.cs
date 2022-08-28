using OnlineShop.Api.ViewModels;
using FluentValidation;

namespace OnlineShop.Api.Validations
{
    public class ProductViewModelAddValidator : AbstractValidator<ProductViewModelAdd>
    {
        public ProductViewModelAddValidator()
        {
            RuleFor(product => product.Name).NotNull();
            RuleFor(product => product.Category).NotNull();
            RuleFor(product => product.Count).NotNull().GreaterThan(0);
        }
    }
}
