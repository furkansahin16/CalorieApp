using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.MealDetails
{
    public class MealDetailCreateDto
    {
        public double Gram { get; set; }
        public int MealID { get; set; }
        public int ProductId { get; set; }

    }
}
