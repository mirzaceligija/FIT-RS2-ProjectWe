using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Configurations
{
    public class CategoriesConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            ConfigureCategoriesTable(builder);
            SeedCategories(builder);
        }

        public void ConfigureCategoriesTable(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(u => u.CategoryId);
            builder.Property(u => u.Description).HasMaxLength(128).IsRequired(true);
            builder.Property(u => u.Description).HasMaxLength(512).IsRequired(false);
            builder.Property(u => u.CreatedAt).ValueGeneratedOnAdd().HasDefaultValue(DateTime.UtcNow);
            builder.Property(u => u.LastModified).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.UtcNow);
        }

        public void SeedCategories(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { CategoryId = 1, Name = "Civic engagement and participation", Description = null, CreatedAt = DateTime.UtcNow, LastModified = null },
                new Category { CategoryId = 2, Name = "Volunteerism and community service", Description = null, CreatedAt = DateTime.UtcNow, LastModified = null },
                new Category { CategoryId = 3, Name = "Youth development", Description = null, CreatedAt = DateTime.UtcNow, LastModified = null },
                new Category { CategoryId = 4, Name = "Neighborhood revitalization", Description = null, CreatedAt = DateTime.UtcNow, LastModified = null },
                new Category { CategoryId = 5, Name = "Interfaith and intercultural understanding", Description = null, CreatedAt = DateTime.UtcNow, LastModified = null },
                new Category { CategoryId = 6, Name = "Aging and elder care", Description = null, CreatedAt = DateTime.UtcNow, LastModified = null },
                new Category { CategoryId = 7, Name = "Food security and access", Description = null, CreatedAt = DateTime.UtcNow, LastModified = null });
        }
    }
}
