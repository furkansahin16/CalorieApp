using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.HelperClasses
{
    public static class CurrentUser
    {
        public static string UserName { get; set; }
        public static UserClaims UserClaim { get; set; }
    }
}
