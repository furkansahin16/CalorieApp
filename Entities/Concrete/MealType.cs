using Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MealType : IEntity
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }

        public MealType()
        {
            Meals = new HashSet<Meal>();
        }

    }
}
