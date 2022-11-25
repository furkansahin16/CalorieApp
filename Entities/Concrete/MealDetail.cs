using Base.Entities;

namespace Entities.Concrete
{
    public class MealDetail:IEntity
    {
        public int Id { get; set; }
        public double? Gram { get; set; }
        public int MealID { get; set; }
        public virtual Meal Meal { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
      
    }

   
}
