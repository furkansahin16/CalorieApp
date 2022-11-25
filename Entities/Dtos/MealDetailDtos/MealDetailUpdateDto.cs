using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.MealDetails
{
    public class MealDetailUpdateDto
    {
        public int Id { get; set; }
        public double? Gram { get; set; }
        public string MealType { get; set; }
        public string ProductName { get; set; }
    }
}
