using Entities.Dtos.Users;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserCreateValidator:AbstractValidator<UserCreateDTO>
    {
        public UserCreateValidator()
        {
            RuleFor(u => u.BirthDate).Must(CheckAgeIfValid).WithMessage("Kullanıcı 18-25 arasında olmalıdır.");
            RuleFor(u => u.UserName).EmailAddress().WithMessage("Girilen kullanıcı adı bir mail adresi olmalıdır.")
                                    .NotEmpty().WithMessage("Kullanıcı adı boş bırakılmamalıdır")
                                    .MaximumLength(100).WithMessage("Kullanıcı adı en fazla 100 karakter olabilir.");
            RuleFor(u => u.Password).NotEmpty().WithMessage("Şifre girişi zorunludur");
            RuleFor(u => u.Password).MinimumLength(8).MaximumLength(16).WithMessage("Şifreniz minimum 8, maksimum 16 karakter olmalıdır.");
            RuleFor(u => u.Password).Matches(@"[A-Z]+").WithMessage("Şifreniz en az bir büyük harf içermelidir.");
            RuleFor(u => u.Password).Matches(@"[a-z]+").WithMessage("Şifreniz en az bir küçük harf içermelidir.");
            RuleFor(u => u.Password).Matches(@"[0-9]+").WithMessage("Şifreniz en az bir rakam içermelidir.");
            
        }

        private bool CheckAgeIfValid(DateTime date)
        {
            int age = DateTime.Now.Year - date.Year;
            return age >= 18 && age <= 25;        
        }
    }
}
