using Business.Exceptions;
using Entities.Concrete;
using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserUpdateValidator : AbstractValidator<UserChangePasswordDTO>
    {
        public UserUpdateValidator()
        {
            RuleFor(u=>u.NewPassword).NotEmpty().WithMessage("Şifre girişi zorunludur");
            RuleFor(u => u.NewPassword).MinimumLength(8).MaximumLength(16).WithMessage("Şifreniz minimum 8, maksimum 16 karakter olmalıdır.");
            RuleFor(u => u.NewPassword).Matches(@"[A-Z]+").WithMessage("Şifreniz en az bir büyük harf içermelidir.");
            RuleFor(u => u.NewPassword).Matches(@"[a-z]+").WithMessage("Şifreniz en az bir küçük harf içermelidir.");
            RuleFor(u => u.NewPassword).Matches(@"[0-9]+").WithMessage("Şifreniz en az bir rakam içermelidir.");
        }


        
    }
}
