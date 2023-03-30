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
    public class VotesConfigurations : IEntityTypeConfiguration<Vote>
    {
        public void Configure(EntityTypeBuilder<Vote> builder)
        {
            ConfigureVotesTable(builder);
            SeedVotes(builder);
        }

        public void ConfigureVotesTable(EntityTypeBuilder<Vote> builder)
        {
            builder.ToTable("Votes");
            builder.HasKey(u => u.VoteId);
            builder.Property(u => u.Positive).IsRequired(true);
            builder.Property(u => u.CreatedAt).ValueGeneratedOnAdd().HasDefaultValue(DateTime.UtcNow);
            builder.Property(u => u.LastModified).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(x => x.Project)
                .WithMany(y => y.Votes)
                .HasForeignKey(x => x.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Votes_ProjectId");

            builder.HasOne(x => x.User)
                .WithMany(y => y.Votes)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Votes_UserId");
        }

        public void SeedVotes(EntityTypeBuilder<Vote> builder)
        {
            builder.HasData(
                new Vote { VoteId = 1, UserId = 1, ProjectId = 1, Positive = true, CreatedAt = DateTime.UtcNow, LastModified = null },
                new Vote { VoteId = 2, UserId = 2, ProjectId = 1, Positive = true, CreatedAt = DateTime.UtcNow, LastModified = null },
                new Vote { VoteId = 3, UserId = 1, ProjectId = 2, Positive = true, CreatedAt = DateTime.UtcNow, LastModified = null },
                new Vote { VoteId = 4, UserId = 2, ProjectId = 2, Positive = false, CreatedAt = DateTime.UtcNow, LastModified = null });
        }
    }
}
