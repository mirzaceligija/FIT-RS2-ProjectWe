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
    public class ActivitiesConfigurations : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            ConfigureActivitiesTable(builder);
            SeedActivities(builder);
        }

        public void ConfigureActivitiesTable(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activities");
            builder.HasKey(u => u.ActivityId);
            builder.Property(u => u.Description).HasMaxLength(512).IsRequired(true);
            builder.Property(u => u.Locations).HasMaxLength(256).IsRequired(false);
            builder.Property(u => u.DirectBeneficiaries).HasMaxLength(256).IsRequired(false);
            builder.Property(u => u.IndirectBeneficiaries).HasMaxLength(256).IsRequired(false);
            builder.Property(u => u.StartDate).IsRequired(true);
            builder.Property(u => u.EndDate).IsRequired(true);
            builder.Property(u => u.CreatedAt).ValueGeneratedOnAdd().HasDefaultValue(DateTime.UtcNow);
            builder.Property(u => u.LastModified).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(d => d.Output)
                .WithMany(p => p.Activities)
                .HasForeignKey(d => d.OutputId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Activity__OutputId");

            builder.HasOne(d => d.Project)
                .WithMany(p => p.Activities)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Activity_ProjectId");

            builder.HasOne(d => d.User)
                .WithMany(p => p.Activities)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Activity_UserId");
        }

        public void SeedActivities(EntityTypeBuilder<Activity> builder)
        {
            builder.HasData(
                new Activity { ActivityId = 1, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 1, OutputId = 1 },
                new Activity { ActivityId = 2, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 2, OutputId = 2 },
                new Activity { ActivityId = 3, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 3, ProjectId = 3, OutputId = 3 },
                new Activity { ActivityId = 4, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 4, ProjectId = 4, OutputId = 4 },
                new Activity { ActivityId = 5, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 5, ProjectId = 5, OutputId = 5 },
                new Activity { ActivityId = 6, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 6, ProjectId = 6, OutputId = 6 },
                new Activity { ActivityId = 7, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7, ProjectId = 7, OutputId = 7 },
                new Activity { ActivityId = 8, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7, ProjectId = 8, OutputId = 8 },
                new Activity { ActivityId = 9, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 8, ProjectId = 9, OutputId = 9 },
                new Activity { ActivityId = 10, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 9, ProjectId = 10, OutputId = 10 },
                new Activity { ActivityId = 11, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 9, ProjectId = 11, OutputId = 11 },
                new Activity { ActivityId = 12, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 10, ProjectId = 12, OutputId = 12 },
                new Activity { ActivityId = 13, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 13, OutputId = 13 },
                new Activity { ActivityId = 14, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 3, ProjectId = 14, OutputId = 14 },
                new Activity { ActivityId = 15, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 4, ProjectId = 15, OutputId = 15 },
                new Activity { ActivityId = 16, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 6, ProjectId = 16, OutputId = 16 },
                new Activity { ActivityId = 17, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7, ProjectId = 17, OutputId = 17 },
                new Activity { ActivityId = 18, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 18, OutputId = 18 },
                new Activity { ActivityId = 19, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 19, OutputId = 19 },
                new Activity { ActivityId = 20, Description = "Test", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 20, OutputId = 20 });
        }
    }
}
