using Castle.Core;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Config
{
    public class MealConfig : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasOne(x => x.MealType).WithMany(x => x.Meals).HasForeignKey(x=> x.MealTypeID).OnDelete(DeleteBehavior.Restrict);
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.MealDetails).WithOne(x => x.Meal).HasForeignKey(x=>x.MealID).OnDelete(DeleteBehavior.Restrict);
            builder.Property(x => x.CreatedDate).HasConversion(typeof(DateTime)).IsRequired(false).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedDate).HasConversion(typeof(DateTime)).IsRequired(false).HasDefaultValue(DateTime.Now);
            builder.HasOne(x => x.User).WithMany(x => x.Meals).HasForeignKey(x => x.UserName).OnDelete(DeleteBehavior.Restrict);


        }
    }


}
