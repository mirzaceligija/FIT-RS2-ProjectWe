using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Configurations
{
    public class CitiesConfigurations : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            ConfigureCitiesTable(builder);
            SeedCities(builder);
        }

        public void ConfigureCitiesTable(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities");
            builder.HasKey(u => u.CityId);
            builder.Property(u => u.Name).HasMaxLength(256).IsRequired(true);
            builder.Property(u => u.CreatedAt).ValueGeneratedOnAdd().HasDefaultValue(DateTime.UtcNow);
            builder.Property(u => u.LastModified).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.UtcNow);
        }

        public void SeedCities(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City { CityId = 1, Name = "Sarajevo", CreatedAt = DateTime.UtcNow, LastModified = null },
                new City { CityId = 2, Name = "Mostar", CreatedAt = DateTime.UtcNow, LastModified = null },
                new City { CityId = 3, Name = "Banja Luka", CreatedAt = DateTime.UtcNow, LastModified = null },
                new City { CityId = 4, Name = "Zenica", CreatedAt = DateTime.UtcNow, LastModified = null },
                new City { CityId = 5, Name = "Tuzla", CreatedAt = DateTime.UtcNow, LastModified = null });
        }
    }
}
