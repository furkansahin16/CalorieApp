using Base.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.Users
{
    public class UserCreateDTO : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
