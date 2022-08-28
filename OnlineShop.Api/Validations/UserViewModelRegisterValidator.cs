using OnlineShop.Api.ViewModels;
using FluentValidation;

namespace OnlineShop.Api.Validations
{
    public class UserViewModelRegisterValidator : AbstractValidator<UserViewModelRegister>
    {
        public UserViewModelRegisterValidator()
        {
            RuleFor(user => user.Name).NotNull().MatchNameRules();
            RuleFor(user => user.Surname).NotNull().MatchNameRules();
            RuleFor(user => user.Phone).NotNull().MatchArmenianPhoneNumberRules();
            RuleFor(user => user.CardNumber).NotNull().MatchCardNumberRules();
            RuleFor(user => user.Password).NotNull().MatchPasswordRules();
            RuleFor(user => user.ConfirmPassword).NotNull();
        }
    }
}
