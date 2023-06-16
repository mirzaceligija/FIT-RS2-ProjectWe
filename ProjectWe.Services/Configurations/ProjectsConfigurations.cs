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
                new Project { ProjectId = 1, Name = "Project 1", Description = "Project Description 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, CityId = 1, CategoryId = 1, StatusId = 1 },
                new Project { ProjectId = 2, Name = "Project 2", Description = "Project Description 2", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, CityId = 1, CategoryId = 2, StatusId = 2 },
                new Project { ProjectId = 3, Name = "Project 3", Description = "Project Description 3", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 3, CityId = 1, CategoryId = 3, StatusId = 3 },
                new Project { ProjectId = 4, Name = "Project 4", Description = "Project Description 4", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 4, CityId = 1, CategoryId = 4, StatusId = 2 },
                new Project { ProjectId = 5, Name = "Project 5", Description = "Project Description 5", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 5, CityId = 2, CategoryId = 5, StatusId = 1 },
                new Project { ProjectId = 6, Name = "Project 6", Description = "Project Description 6", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 6, CityId = 2, CategoryId = 6, StatusId = 2 },
                new Project { ProjectId = 7, Name = "Project 7", Description = "Project Description 7", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7, CityId = 2, CategoryId = 7, StatusId = 3 },
                new Project { ProjectId = 8, Name = "Project 8", Description = "Project Description 8", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7, CityId = 2, CategoryId = 1, StatusId = 2 },
                new Project { ProjectId = 9, Name = "Project 9", Description = "Project Description 9", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 8, CityId = 3, CategoryId = 2, StatusId = 1 },
                new Project { ProjectId = 10, Name = "Project 10", Description = "Project Description 10", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 9, CityId = 3, CategoryId = 3, StatusId = 2 },
                new Project { ProjectId = 11, Name = "Project 11", Description = "Project Description 11", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 9, CityId = 3, CategoryId = 4, StatusId = 3 },
                new Project { ProjectId = 12, Name = "Project 12", Description = "Project Description 12", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 10, CityId = 3, CategoryId = 5, StatusId = 1 },
                new Project { ProjectId = 13, Name = "Project 13", Description = "Project Description 13", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, CityId = 4, CategoryId = 6, StatusId = 1 },
                new Project { ProjectId = 14, Name = "Project 14", Description = "Project Description 14", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 3, CityId = 4, CategoryId = 7, StatusId = 1 },
                new Project { ProjectId = 15, Name = "Project 15", Description = "Project Description 15", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 4, CityId = 4, CategoryId = 1, StatusId = 2 },
                new Project { ProjectId = 16, Name = "Project 16", Description = "Project Description 16", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 6, CityId = 4, CategoryId = 2, StatusId = 3 },
                new Project { ProjectId = 17, Name = "Project 17", Description = "Project Description 17", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7, CityId = 5, CategoryId = 2, StatusId = 3 },
                new Project { ProjectId = 18, Name = "Project 18", Description = "Project Description 18", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, CityId = 5, CategoryId = 3, StatusId = 3 },
                new Project { ProjectId = 19, Name = "Project 19", Description = "Project Description 19", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, CityId = 5, CategoryId = 4, StatusId = 4 },
                new Project { ProjectId = 20, Name = "Project 20", Description = "Project Description 20", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, CityId = 5, CategoryId = 5, StatusId = 4 });
        }
    }
}
