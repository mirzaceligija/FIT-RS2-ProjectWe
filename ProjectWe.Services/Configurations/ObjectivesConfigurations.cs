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
                new Objective { ObjectiveId = 2, ProjectId = 2, Description = "Objective 2", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 },
                new Objective { ObjectiveId = 3, ProjectId = 3, Description = "Objective 3", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 3 },
                new Objective { ObjectiveId = 4, ProjectId = 4, Description = "Objective 4", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 4 },
                new Objective { ObjectiveId = 5, ProjectId = 5, Description = "Objective 5", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 5 },
                new Objective { ObjectiveId = 6, ProjectId = 6, Description = "Objective 6", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 6 },
                new Objective { ObjectiveId = 7, ProjectId = 7, Description = "Objective 7", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7 },
                new Objective { ObjectiveId = 8, ProjectId = 8, Description = "Objective 8", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7 },
                new Objective { ObjectiveId = 9, ProjectId = 9, Description = "Objective 9", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 8 },
                new Objective { ObjectiveId = 10, ProjectId = 10, Description = "Objective 10", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 9 },
                new Objective { ObjectiveId = 11, ProjectId = 11, Description = "Objective 11", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 9 },
                new Objective { ObjectiveId = 12, ProjectId = 12, Description = "Objective 12", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 10 },
                new Objective { ObjectiveId = 13, ProjectId = 13, Description = "Objective 13", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 },
                new Objective { ObjectiveId = 14, ProjectId = 14, Description = "Objective 14", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 3 },
                new Objective { ObjectiveId = 15, ProjectId = 15, Description = "Objective 15", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 4 },
                new Objective { ObjectiveId = 16, ProjectId = 16, Description = "Objective 16", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 6 },
                new Objective { ObjectiveId = 17, ProjectId = 17, Description = "Objective 17", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7 },
                new Objective { ObjectiveId = 18, ProjectId = 18, Description = "Objective 18", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 },
                new Objective { ObjectiveId = 19, ProjectId = 19, Description = "Objective 19", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 },
                new Objective { ObjectiveId = 20, ProjectId = 20, Description = "Objective 20", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 });
        }
    }
}
