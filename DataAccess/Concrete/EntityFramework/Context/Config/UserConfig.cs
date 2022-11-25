using Base.Utilities.Encryption;
using Entities.Concrete;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.UserName);
            builder.Property(x => x.UserName).IsUnicode().IsRequired(true).HasMaxLength(350);
            builder.Property(x => x.PasswordHash).IsRequired(true).HasColumnType("varbinary").HasMaxLength(500);
            builder.Property(x => x.RegisterTime).HasConversion(typeof(DateTime)).IsRequired(false).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.BirthDate).HasConversion(typeof(DateTime)).IsRequired(false);
            builder.Property(x => x.UserClaim);

            byte[] passwordHash;
            HashingHelper.CreatePasswordHash("admin", out passwordHash);
            builder.HasData(new User { BirthDate = DateTime.Now, UserName = "admin", PasswordHash = passwordHash });

        }
    }


}
