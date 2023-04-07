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
    public class StatusesConfigurations : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            ConfigureStatusesTable(builder);
            SeedStatuses(builder);
        }

        public void ConfigureStatusesTable(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Statuses");
            builder.HasKey(u => u.StatusId);
            builder.Property(u => u.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(u => u.Description).HasMaxLength(1024).IsRequired(false);
            builder.Property(u => u.CreatedAt).ValueGeneratedOnAdd().HasDefaultValue(DateTime.UtcNow);
            builder.Property(u => u.LastModified).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.UtcNow);
        }

        public void SeedStatuses(EntityTypeBuilder<Status> builder)
        {
            builder.HasData(
                new Status { StatusId = 1, Name = "Submitted", CreatedAt = DateTime.UtcNow, LastModified = null },
                new Status { StatusId = 2, Name = "Needs Improvment", CreatedAt = DateTime.UtcNow, LastModified = null },
                new Status { StatusId = 3, Name = "Active", CreatedAt = DateTime.UtcNow, LastModified = null },
                new Status { StatusId = 4, Name = "Completed", CreatedAt = DateTime.UtcNow, LastModified = null });
        }
    }
}
