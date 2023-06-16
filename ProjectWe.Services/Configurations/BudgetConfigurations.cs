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
    public class BudgetConfigurations : IEntityTypeConfiguration<Budget>
    {
        public void Configure(EntityTypeBuilder<Budget> builder)
        {
            ConfigureBudgetsTable(builder);
            SeedBudgets(builder);
        }

        public void ConfigureBudgetsTable(EntityTypeBuilder<Budget> builder)
        {
            builder.ToTable("Budgets");
            builder.HasKey(u => u.BudgetId);
            builder.Property(u => u.Description).HasMaxLength(512).IsRequired(true);
            builder.Property(u => u.CostPerUnit).HasColumnType("decimal(18,2)").IsRequired(true);
            builder.Property(u => u.NumberOfUnits).HasColumnType("int").IsRequired(true);
            builder.Property(u => u.TotalCost).HasColumnType("decimal(18,2)").HasComputedColumnSql("([CostPerUnit]*[NumberOfUnits])", false).IsRequired(false);
            builder.Property(u => u.CreatedAt).ValueGeneratedOnAdd().HasDefaultValue(DateTime.UtcNow);
            builder.Property(u => u.LastModified).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(d => d.Activity)
                    .WithMany(p => p.Budgets)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Budgets__ActivityId");

            builder.HasOne(d => d.Project)
                .WithMany(p => p.Budgets)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Budgets_ProjectId");

            builder.HasOne(d => d.User)
                .WithMany(p => p.Budgets)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Budgets_UserId");
        }

        public void SeedBudgets(EntityTypeBuilder<Budget> builder)
        {
            builder.HasData(
                new Budget { BudgetId = 1, ActivityId = 1, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 1 },
                new Budget { BudgetId = 2, ActivityId = 2, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 2 },
                new Budget { BudgetId = 3, ActivityId = 3, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 3, ProjectId = 3 },
                new Budget { BudgetId = 4, ActivityId = 4, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 4, ProjectId = 4 },
                new Budget { BudgetId = 5, ActivityId = 5, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 5, ProjectId = 5 },
                new Budget { BudgetId = 6, ActivityId = 6, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 6, ProjectId = 6 },
                new Budget { BudgetId = 7, ActivityId = 7, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7, ProjectId = 7 },
                new Budget { BudgetId = 8, ActivityId = 8, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7, ProjectId = 8 },
                new Budget { BudgetId = 9, ActivityId = 9, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 8, ProjectId = 9 },
                new Budget { BudgetId = 10, ActivityId = 10, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 9, ProjectId = 10 },
                new Budget { BudgetId = 11, ActivityId = 11, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 9, ProjectId = 11 },
                new Budget { BudgetId = 12, ActivityId = 12, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 10, ProjectId = 12 },
                new Budget { BudgetId = 13, ActivityId = 13, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 13 },
                new Budget { BudgetId = 14, ActivityId = 14, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 3, ProjectId = 14 },
                new Budget { BudgetId = 15, ActivityId = 15, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 4, ProjectId = 15 },
                new Budget { BudgetId = 16, ActivityId = 16, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 6, ProjectId = 16 },
                new Budget { BudgetId = 17, ActivityId = 17, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 7, ProjectId = 17 },
                new Budget { BudgetId = 18, ActivityId = 18, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 18 },
                new Budget { BudgetId = 19, ActivityId = 19, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 19 },
                new Budget { BudgetId = 20, ActivityId = 20, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 20 });
        }
    }
}
