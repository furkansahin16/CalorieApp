using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Config
{
    public class ProductTypeConfig : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductTypeName).IsUnicode().IsRequired(true).HasMaxLength(20);
            builder.HasData(
               new ProductType{Id=1, ProductTypeName="Et" },
               new ProductType{Id=2, ProductTypeName="Balık" },
               new ProductType{Id=3, ProductTypeName="Temel Gıda" },
               new ProductType{Id=4, ProductTypeName="Sebze" },
               new ProductType{Id=5, ProductTypeName="Meyve" },
               new ProductType{Id=6, ProductTypeName="Lokanta Yemeği" }
                );

        }
    }


}
