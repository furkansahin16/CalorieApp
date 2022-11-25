using Base.Entities;

namespace Entities.VMs.MealTypeVMs
{
    public class MealTypeVm:IViewModel
    {
        public int Id { get; set; }
        public string MealTypeName { get; set; }
        public override string ToString()
        {
            return this.MealTypeName;
        }
    }
}
