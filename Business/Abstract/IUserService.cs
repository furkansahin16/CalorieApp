using Entities.Dtos;
using Entities.Dtos.Users;
using Entities.Enums;
using Entities.VMs.UserVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Register(UserCreateDTO user);
        UserVm Login(UserLoginDTO user);

        void ChangePassword(UserChangePasswordDTO userChangePassword);

        List<UserVm> GetAll();
        UserVm Get(string id);

    }

}
