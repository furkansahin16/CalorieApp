using Entities.Dtos.Product;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductCreateValidator: AbstractValidator<ProductCreateDTO>
    {
        public ProductCreateValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Yemek adı boş olamaz.");
            RuleFor(x => x.ProductName).NotNull().WithMessage("Yemek adı boş olamaz.");
            RuleFor(x => x.ProductName).MaximumLength(30).WithMessage("Yemek adı 30 karakterden büyük olamaz");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("Yemek adı 2 karakterden küçük olamaz");

            RuleFor(u => u.UnitCalorie).GreaterThanOrEqualTo(0).WithMessage("Ölçülebilir bir kalori miktarı belirtiniz.");
            RuleFor(u => u.UnitCalorie).LessThan(20).WithMessage("Lütfen girilen miktarı kontrol ediniz.");
            RuleFor(u => u.UnitCalorie).NotNull().WithMessage("Birim kalori boş bırakılamaz.");

            RuleFor(x => x.ProductType).NotNull().WithMessage("Yemek türü boş olamaz.");
            RuleFor(x => x.ProductType).NotEmpty().WithMessage("Yemek türü boş olamaz.");
            RuleFor(x => x.ProductType).MaximumLength(30).WithMessage("Yemek türü 30 karakterden büyük olamaz");

   
        }
        private bool isContainsOnlyLetters(string productName)
        {
            return Regex.IsMatch(productName, @"^[a-zA-Z]+$");
        }
        




    }
}
