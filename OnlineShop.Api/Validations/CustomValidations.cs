using FluentValidation;
using FluentValidation.Validators;

namespace OnlineShop.Api.Validations
{
    public static class CustomValidations
    {
        public static IRuleBuilderOptions<T, string> MatchNameRules<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new RegularExpressionValidator<T>(@"^[a-zA-Z]*$"));
        }

        public static IRuleBuilderOptions<T, string> MatchArmenianPhoneNumberRules<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new RegularExpressionValidator<T>(@"^374[0-9]{8}"));
        }

        public static IRuleBuilderOptions<T, string> MatchCardNumberRules<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new RegularExpressionValidator<T>(@"^[0-9]{16}"));
        }

        public static IRuleBuilderOptions<T, string> MatchPasswordRules<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new RegularExpressionValidator<T>(@"^[a-zA-Z0-9]{8,}$"))
                .WithMessage("Password must contain minimum 8 Character with lowercase, uppercase letters and numbers");
        }
    }
}
