using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Configurations
{
    public class AppRolesConfigurations : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            ConfigureRolesTable(builder);
            SeedRoles(builder);
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

        public void SeedRoles(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                new AppRole { Id = 1, Name = "Admin", NormalizedName = "ADMIN", CreatedAt = DateTime.UtcNow, LastModified = null},
                new AppRole { Id = 2, Name = "Manager", NormalizedName = "MANAGER", CreatedAt = DateTime.UtcNow, LastModified = null });
        }
    }
}
