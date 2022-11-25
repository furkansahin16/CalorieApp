using Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.Meal
{
    public class MealUpdateDTO:IDto
    {
        public int Id { get; set; }
        public string MealName { get; set; }
    }
}
