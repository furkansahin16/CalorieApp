using Base.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.VMs.UserVMs
{
    public class UserVm:IViewModel
    {
        public string UserName { get; set; }
        public UserClaims UserClaim { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
