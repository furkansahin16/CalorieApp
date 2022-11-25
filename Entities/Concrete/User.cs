using Base.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public DateTime? BirthDate { get; set; }
        public UserClaims UserClaim { get; set; }
        public DateTime? RegisterTime { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }

        public User()
        {
            Meals = new HashSet<Meal>();
        }
    }

   
}
