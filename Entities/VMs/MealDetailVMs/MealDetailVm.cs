using Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.VMs.MealDetailVMs
{
    public class MealDetailVm:IViewModel
    {
        public int Id { get; set; }
        public string MealType { get; set; }
        public string Product { get; set; }
        public string ProductType { get; set; }
        public double? UnitCalorie { get; set; }
        public double? Gram { get; set; }
        public byte[] Image { get; set; }
    }
}
