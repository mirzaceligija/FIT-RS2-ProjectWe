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
    public class OutputsConfigurations : IEntityTypeConfiguration<Output>
    {
        public void Configure(EntityTypeBuilder<Output> builder)
        {
            ConfigureOutputsTable(builder);
            SeedOutputs(builder);
        }

        public void ConfigureOutputsTable(EntityTypeBuilder<Output> builder)
        {
            builder.ToTable("Outputs");
            builder.HasKey(u => u.OutputId);
            builder.Property(u => u.Description).HasMaxLength(512).IsRequired(true);
            builder.Property(u => u.Indicators).HasMaxLength(512).IsRequired(false);
            builder.Property(u => u.MeansOfVerification).HasMaxLength(512).IsRequired(false);
            builder.Property(u => u.CreatedAt).ValueGeneratedOnAdd().HasDefaultValue(DateTime.UtcNow);
            builder.Property(u => u.LastModified).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(d => d.Objective)
                .WithMany(p => p.Outputs)
                .HasForeignKey(d => d.ObjectiveId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Outputs_ObjectiveId");

            builder.HasOne(d => d.Project)
                .WithMany(p => p.Outputs)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Outputs_ProjectId");

            builder.HasOne(d => d.User)
                .WithMany(p => p.Outputs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Outputs_UserId");
        }

        public void SeedOutputs(EntityTypeBuilder<Output> builder)
        {
            builder.HasData(
                new Output { OutputId = 1, ProjectId = 1, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 },
                new Output { OutputId = 2, ProjectId = 2, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 },
                new Output { OutputId = 3, ProjectId = 3, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 3 },
                new Output { OutputId = 4, ProjectId = 4, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 4 },
                new Output { OutputId = 5, ProjectId = 5, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 5 },
                new Output { OutputId = 6, ProjectId = 6, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 6 },
                new Output { OutputId = 7, ProjectId = 7, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7 },
                new Output { OutputId = 8, ProjectId = 8, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7 },
                new Output { OutputId = 9, ProjectId = 9, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 8 },
                new Output { OutputId = 10, ProjectId = 10, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 9 },
                new Output { OutputId = 11, ProjectId = 11, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 9 },
                new Output { OutputId = 12, ProjectId = 12, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 10 },
                new Output { OutputId = 13, ProjectId = 13, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 },
                new Output { OutputId = 14, ProjectId = 14, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 3 },
                new Output { OutputId = 15, ProjectId = 15, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 4 },
                new Output { OutputId = 16, ProjectId = 16, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 6 },
                new Output { OutputId = 17, ProjectId = 17, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7 },
                new Output { OutputId = 18, ProjectId = 18, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 },
                new Output { OutputId = 19, ProjectId = 19, ObjectiveId = 1, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 },
                new Output { OutputId = 20, ProjectId = 20, ObjectiveId = 2, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 });
        }
    }
}
