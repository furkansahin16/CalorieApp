using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Config
{
    public class MealTypeConfig : IEntityTypeConfiguration<MealType>
    {
        public void Configure(EntityTypeBuilder<MealType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.TypeName).IsRequired(true).HasMaxLength(25);
            builder.HasData(
                new MealType { Id=1, TypeName="Kahvaltı" },
                new MealType { Id=2, TypeName="Ara Öğün" },
                new MealType { Id=3, TypeName="Öğle Yemeği" },
                new MealType { Id=4, TypeName="Akşam Yemeği" }
                );
        }
    }


}
