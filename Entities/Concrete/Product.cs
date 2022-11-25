using Base.Entities;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double? UnitCalorie { get; set; }
        public int ProductTypeID { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<MealDetail> MealDetails { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] Image { get; set; }
        public bool isActive { get; set; } = true;

        public Product()
        {
            MealDetails = new HashSet<MealDetail>();
        }

    }

   
}
