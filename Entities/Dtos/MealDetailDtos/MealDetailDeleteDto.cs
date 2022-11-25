using Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.MealDetails
{
    public class MealDetailDeleteDto:IDto
    {
        public int Id { get; set; }
    }
}
