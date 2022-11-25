using Base.Entities;
using Entities.VMs.MealDetailVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.VMs.MealVMs
{
    public class MealVm:IViewModel
    {
        public int Id { get; set; }
        public List<MealDetailVm> MealDetailVm { get; set; }
        public string MealType { get; set; }
        public DateTime? Date { get; set; }
        public MealVm()
        {
            MealDetailVm =new List<MealDetailVm>();
        }

        public override string ToString()
        {
            return this.MealType;
        }
    }
}
