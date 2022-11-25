using Entities.Concrete;
using Entities.Dtos.Meal;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class MealCreateValidator : AbstractValidator<MealCreateDTO>
    {
        
        public MealCreateValidator()
        {
            RuleFor(u => u.MealTypeName).NotNull().WithMessage("Yemek türü boş olamaz.");
            RuleFor(u => u.MealTypeName).NotEmpty().WithMessage("Yemek türü boş olamaz.");
            RuleFor(x => x.MealTypeName).MaximumLength(30).WithMessage("Yemek türü 30 karakterden büyük olamaz");
            RuleFor(x => x.MealTypeName).MinimumLength(2).WithMessage("Yemek türü 2 karakterden küçük olamaz");

            //Gerekliliği kontrol edilecek.
            RuleFor(u => u.UserName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz.");
            RuleFor(u => u.UserName).NotNull().WithMessage("Kullanıcı adı boş olamaz.");


        }
        private bool isContainsOnlyLetters(string productName)
        {
            return Regex.IsMatch(productName, @"^[a-zA-Z]+$");
        }
    }
}
    

