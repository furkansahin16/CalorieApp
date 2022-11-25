using Entities.Dtos.Meal;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class MealUpdateValidator : AbstractValidator<MealUpdateDTO>
    {
        public MealUpdateValidator()
        {
            RuleFor(x => x.MealName).NotEmpty().WithMessage("Öğün adı boş olamaz.");
            RuleFor(x => x.MealName).NotNull().WithMessage("Öğün adı boş olamaz.");
            RuleFor(x => x.MealName).MaximumLength(30).WithMessage("Öğün adı 30 karakterden büyük olamaz");
            RuleFor(x => x.MealName).MinimumLength(2).WithMessage("Öğün adı 2 karakterden küçük olamaz");

        }
        private bool isContainsOnlyLetters(string productName)
        {
            return Regex.IsMatch(productName, @"^[a-zA-Z]+$");
        }
    }
}
