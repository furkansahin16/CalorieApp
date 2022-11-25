using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Config
{
    public class MealDetailConfig : IEntityTypeConfiguration<MealDetail>
    {
        public void Configure(EntityTypeBuilder<MealDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Gram).IsRequired(true);
            //builder.Property(x => x.MealDate).HasConversion(typeof(DateTime)).IsRequired(false).HasDefaultValue(DateTime.Now);
            builder.HasOne(x=> x.Product).WithMany(x=> x.MealDetails).HasForeignKey(x=> x.ProductId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(x => x.User).WithMany(x => x.MealDetail).HasForeignKey(x=> x.UserName).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Meal).WithMany(x => x.MealDetails).HasForeignKey(x=> x.MealID).OnDelete(DeleteBehavior.Restrict);
        }
    }


}
