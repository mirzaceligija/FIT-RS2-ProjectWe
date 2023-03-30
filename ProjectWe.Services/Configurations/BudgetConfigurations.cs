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
                new Budget { BudgetId = 2, ActivityId = 1, Description = "Test", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 2, ProjectId = 1 });
        }
    }
}
