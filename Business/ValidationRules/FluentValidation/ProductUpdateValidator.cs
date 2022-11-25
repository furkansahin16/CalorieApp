using Entities.Concrete;
using Entities.Dtos.Product;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductUpdateValidator : AbstractValidator<ProductUpdateDTO>
    {
        public ProductUpdateValidator()
        {
            RuleFor(p => p.ProductName).NotNull().WithMessage("Yemek adı boş olmamalıdır").NotEmpty().WithMessage("Yemek adı boş olmamalıdır")
                                       .MinimumLength(2).WithMessage("Yemek adı en az 2 harften oluşmalıdır.")
                                       .MaximumLength(30).WithMessage("Yemek adı en fazla 30 harften oluşmalıdır.");

            RuleFor(p => p.UnitCalorie).GreaterThanOrEqualTo(0).WithMessage("Yemeğin birim kalorisi sıfırdan küçük olamaz")
                                       .LessThan(20).WithMessage("Yemeğin birim kalorisi 20den büyük olamaz")
                                       .NotNull().WithMessage("Yemeğin birim kalorisi boş bırakılamaz");

            RuleFor(p => p.ProductType).NotNull().WithMessage("Yemek türü boş olamaz")
                                       .NotEmpty().WithMessage("Yemek türü boş olamaz");


            
        }

        private bool isContainsOnlyLetters(string productName)
        {
            return Regex.IsMatch(productName, @"^[a-zA-Z]+$");
        }
    }
}
