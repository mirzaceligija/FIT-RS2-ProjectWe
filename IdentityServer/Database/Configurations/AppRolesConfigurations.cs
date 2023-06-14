using IdentityServer.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityServer.Database.Configurations
{
    public class AppRolesConfigurations : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            ConfigureRolesTable(builder);
        }

        public void ConfigureRolesTable(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("AppRoles");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).HasMaxLength(256).IsRequired(true);
            builder.Property(u => u.NormalizedName).HasMaxLength(256).IsRequired(true);
            builder.Property(u => u.CreatedAt).ValueGeneratedOnAdd().HasDefaultValue(DateTime.UtcNow);
            builder.Property(u => u.LastModified).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.UtcNow);
        }
    }
}
