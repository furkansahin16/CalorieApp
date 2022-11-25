using Entities.Dtos.MealDetails;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class MealDetailUpdateValidator : AbstractValidator<MealDetailUpdateDto>
    {
        public MealDetailUpdateValidator()
        {
            RuleFor(x=> x.MealType).NotEmpty().WithMessage("Öğün türü boş olamaz.");
            RuleFor(x=> x.MealType).NotNull().WithMessage("Öğün türü boş olamaz.");
            RuleFor(x => x.MealType).MaximumLength(30).WithMessage("Öğün türü 30 karakterden büyük olamaz");
            RuleFor(x => x.MealType).MinimumLength(4).WithMessage("Öğün türü 4 karakterden küçük olamaz");


            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Yemek Adı boş olamaz.");
            RuleFor(x => x.ProductName).NotNull().WithMessage("Yemek Adı boş olamaz.");
            RuleFor(x => x.ProductName).MaximumLength(30).WithMessage("Yemek Adı 30 karakterden büyük olamaz.");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("Yemek Adı 2 karakterden büyük olamaz.");

            RuleFor(u => u.Gram).NotEmpty().WithMessage("Gram miktarı belirtiniz.");
            RuleFor(u => u.Gram).NotNull().WithMessage("Gram miktarı belirtiniz.");
            RuleFor(u => u.Gram).GreaterThan(0).WithMessage("Ölçülebilir bir gram miktarı belirtiniz.");
            RuleFor(u => u.Gram).LessThan(1000).WithMessage("Lütfen girilen miktarı kontrol ediniz.");

        }
        private bool isContainsOnlyLetters(string productName)
        {
            return Regex.IsMatch(productName, @"^[a-zA-Z]+$");
        }
    }
}
