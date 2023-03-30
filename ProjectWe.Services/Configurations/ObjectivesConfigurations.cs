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
    public class ObjectivesConfigurations : IEntityTypeConfiguration<Objective>
    {
        public void Configure(EntityTypeBuilder<Objective> builder)
        {
            ConfigureObjectivesTable(builder);
            SeedObjectives(builder);
        }

        public void ConfigureObjectivesTable(EntityTypeBuilder<Objective> builder)
        {
            builder.ToTable("Objectives");
            builder.HasKey(u => u.ObjectiveId);
            builder.Property(u => u.Description).HasMaxLength(512).IsRequired(true);
            builder.Property(u => u.CreatedAt).ValueGeneratedOnAdd().HasDefaultValue(DateTime.UtcNow);
            builder.Property(u => u.LastModified).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(d => d.Project)
                .WithMany(p => p.Objectives)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Objective_ProjectId");

            builder.HasOne(d => d.User)
                .WithMany(p => p.Objectives)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Objective_UserId");
        }

        public void SeedObjectives(EntityTypeBuilder<Objective> builder)
        {
            builder.HasData(
                new Objective { ObjectiveId = 1, ProjectId = 1, Description = "Objective 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 },
                new Objective { ObjectiveId = 2, ProjectId = 1, Description = "Objective 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 });
        }
    }
}
