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
    public class ProjectsConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            ConfigureProjectsTable(builder);
            SeedProjects(builder);
        }

        public void ConfigureProjectsTable(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");
            builder.HasKey(u => u.ProjectId);
            builder.Property(u => u.Name).HasMaxLength(256).IsRequired(true);
            builder.Property(u => u.Description).HasMaxLength(512).IsRequired(false);
            builder.Property(u => u.CreatedAt).ValueGeneratedOnAdd().HasDefaultValue(DateTime.UtcNow);
            builder.Property(u => u.LastModified).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(d => d.Category)
                .WithMany(p => p.Projects)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Projects_CategoryId");

            builder.HasOne(d => d.Status)
                .WithMany(p => p.Projects)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Projects_StatusId");

            builder.HasOne(d => d.City)
                .WithMany(p => p.Projects)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Projects_CityId");

            builder.HasOne(d => d.User)
                .WithMany(p => p.Projects)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Projects_UserId");
        }

        public void SeedProjects(EntityTypeBuilder<Project> builder)
        { 
            builder.HasData(
                new Project { ProjectId = 1, Name = "Project 1", Description = "Project Description 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 1, CityId = 1, CategoryId = 1, StatusId = 3 },
                new Project { ProjectId = 2, Name = "Project 2", Description = "Project Description 2", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 1, CityId = 2, CategoryId = 2, StatusId = 3 });
        }
    }
}
