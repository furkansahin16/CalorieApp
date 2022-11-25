using Base.Aspects.Autofac.Validation;
using Base.Utilities.Encryption;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Exceptions;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;
using Entities.Dtos.Users;
using Entities.Enums;
using Entities.VMs.UserVMs;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [ValidationAspect(typeof(UserUpdateValidator))]
        public void ChangePassword(UserChangePasswordDTO userChangePassword)
        {
            var getUserTuple = _userDal.Get(u => u.UserName == userChangePassword.UserName);
            User registeredUser = getUserTuple.Item1;
            if (registeredUser == null)
            {
                throw new LoginFailedException("Kullanıcı adı veya şifre hatalı.");
            }

            if (!HashingHelper.VerifyPasswordHash(userChangePassword.OldPassword, registeredUser.PasswordHash))
            {
                throw new LoginFailedException("Kullanıcı adı veya şifre hatalı.");
            }
            if(userChangePassword.OldPassword == userChangePassword.NewPassword)
            {
                throw new SamePasswordException("Yeni şifre eski şifrenizden farklı olmalıdır.");
            }

            byte[] newHashedPassword;
            HashingHelper.CreatePasswordHash(userChangePassword.NewPassword, out newHashedPassword);
            registeredUser.PasswordHash = newHashedPassword;
            getUserTuple.Item2.Dispose();
            _userDal.Update(registeredUser);
        }

        [SecuredOperation(UserClaims.Admin)]
        public UserVm Get(string id)
        {
            var getUserTuple = _userDal.Get(u => u.UserName == id);
            User user = getUserTuple.Item1;
            UserVm userVm = new UserVm()
            {
                UserName = user.UserName,
                UserClaim = user.UserClaim,
                RegisterDate = user.RegisterTime,
                BirthDate = user.BirthDate
            };
            getUserTuple.Item2.Dispose();
            return userVm;
        }

        [SecuredOperation(UserClaims.Admin)]
        public List<UserVm> GetAll()
        {
            var getAllUserTuple = _userDal.GetAll();
            List<User> userList = getAllUserTuple.Item1;
            List<UserVm> userVmList = new List<UserVm>();
            foreach (User item in userList)
            {
                UserVm userVm = new UserVm()
                {
                    BirthDate = item.BirthDate,
                    RegisterDate = item.RegisterTime,
                    UserClaim = item.UserClaim,
                    UserName = item.UserName
                };
                userVmList.Add(userVm);
            }
            getAllUserTuple.Item2.Dispose();
            return userVmList;
        }

        public UserVm Login(UserLoginDTO user)
        {
            var getUserTuple = _userDal.Get(u => u.UserName == user.UserName);
            User registeredUser = getUserTuple.Item1;
            if (registeredUser == null)
            {
                throw new LoginFailedException("Kullanıcı adı veya şifre hatalı.");
            }
            if (user.UserName != registeredUser.UserName || !(HashingHelper.VerifyPasswordHash(user.Password, registeredUser.PasswordHash)))
            {
                throw new LoginFailedException("Kullanıcı adı veya şifre hatalı.");
            }

            UserVm userVm = new UserVm()
            {
                UserClaim = registeredUser.UserClaim,
                UserName = registeredUser.UserName,
            };
            getUserTuple.Item2.Dispose();
            return userVm;
        }

        [ValidationAspect(typeof(UserCreateValidator))]
        public void Register(UserCreateDTO user)
        {
            var getUserTuple = _userDal.Get(u => u.UserName == user.UserName);
            if (getUserTuple.Item1!= null)
            {
                throw new AlreadyExistsException("Bu kullanıcı adı daha önce alınmış");
            }
            

            byte[] password;
            HashingHelper.CreatePasswordHash(user.Password, out password);
            User newUser = new User()
            {
                BirthDate = user.BirthDate,
                UserName = user.UserName,
                PasswordHash = password,
                RegisterTime = DateTime.Now,
                UserClaim = UserClaims.User
            };
            getUserTuple.Item2.Dispose();
            _userDal.Add(newUser);
        }


    }

}
