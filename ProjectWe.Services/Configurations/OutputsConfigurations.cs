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
                new Output { OutputId = 2, ProjectId = 1, ObjectiveId = 2, Description = "Output 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2 });
        }
    }
}
