using Entities.Concrete;
using Entities.Dtos.MealDetails;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class MealDetailCreateValidator: AbstractValidator<MealDetailCreateDto>
    {
       
        public MealDetailCreateValidator()
        {
            RuleFor(u => u.Gram).NotEmpty().WithMessage("Gram miktarı belirtiniz.");
            RuleFor(u => u.Gram).NotNull().WithMessage("Gram miktarı belirtiniz.");
            RuleFor(u => u.Gram).GreaterThan(0).WithMessage("Ölçülebilir bir gram miktarı belirtiniz.");
            RuleFor(u => u.Gram).LessThan(1000).WithMessage("Lütfen girilen miktarı kontrol ediniz.");

        }
    }
}
