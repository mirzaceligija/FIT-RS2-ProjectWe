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
    public class ReviewsConfigurations : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            ConfigureReviewsTable(builder);
            SeedReviews(builder);
        }

        public void ConfigureReviewsTable(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Reviews");
            builder.HasKey(u => u.ReviewId);
            builder.Property(u => u.Description).HasMaxLength(2048).IsRequired(true);
            builder.Property(u => u.CreatedAt).ValueGeneratedOnAdd().HasDefaultValue(DateTime.UtcNow);
            builder.Property(u => u.LastModified).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(d => d.Project)
                .WithMany(p => p.Reviews)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reviews_ProjectId");

            builder.HasOne(d => d.User)
                .WithMany(p => p.Reviews)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reviews_UserId");

            builder.HasOne(d => d.Status)
                .WithMany(p => p.Reviews)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reviews_StatusId");
        }

        public void SeedReviews(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                new Review { ReviewId = 1, ProjectId = 1, Description = "Review 1", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 1, StatusId = 2 },
                new Review { ReviewId = 2, ProjectId = 2, Description = "Review 2", CreatedAt = DateTime.UtcNow, LastModified = null, UserId = 1, StatusId = 3 });
        }
    }
}
