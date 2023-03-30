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
                new Activity { ActivityId = 1, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 1, OutputId = 1 },
                new Activity { ActivityId = 2, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 1, OutputId = 1 });
        }
    }
}
