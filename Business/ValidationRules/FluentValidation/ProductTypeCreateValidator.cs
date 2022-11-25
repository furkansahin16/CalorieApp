using Entities.Concrete;
using Entities.Dtos.MealType;
using Entities.Dtos.ProductTypes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductTypeCreateValidator : AbstractValidator<ProductTypeCreateDto>   
    {
        public ProductTypeCreateValidator()
        {
            RuleFor(x => x.ProductTypeName).NotEmpty().WithMessage("Yemek türü  boş olamaz.");
            RuleFor(x => x.ProductTypeName).NotNull().WithMessage("Yemek türü boş olamaz.");
            RuleFor(x => x.ProductTypeName).MaximumLength(30).WithMessage("Yemek türü 30 karakterden büyük olamaz");
            RuleFor(x => x.ProductTypeName).MinimumLength(2).WithMessage("Yemek türü 2 karakterden küçük olamaz");
        }
        private bool isContainsOnlyLetters(string productName)
        {
            return Regex.IsMatch(productName, @"^[a-zA-Z]+$");
        }
    }
}
