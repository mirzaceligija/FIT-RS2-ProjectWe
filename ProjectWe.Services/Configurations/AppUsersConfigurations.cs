﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Configurations
{
    public class AppUsersConfigurations : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            ConfigureUsersTable(builder);
        }

        public void ConfigureUsersTable(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.NormalizedUserName).HasMaxLength(64).IsRequired(false);
            builder.Property(u => u.Email).HasMaxLength(320).IsRequired(true);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.NormalizedEmail).HasMaxLength(320).IsRequired(true);
            builder.HasIndex(u => u.NormalizedEmail).IsUnique();
            builder.Property(u => u.FirstName).HasMaxLength(64).IsRequired(true);
            builder.Property(u => u.LastName).HasMaxLength(64).IsRequired(true);
            builder.Property(u => u.UserName).HasMaxLength(64).IsRequired(true);
            builder.HasIndex(u => u.UserName).IsUnique();
            builder.Property(u => u.NormalizedUserName).HasMaxLength(64).IsRequired(false);
            builder.HasIndex(u => u.NormalizedUserName).IsUnique();
            builder.Property(u => u.EmailConfirmed).IsRequired(true).HasDefaultValue(false);
            builder.Property(u => u.PasswordHash).HasMaxLength(4096).IsRequired(true);
            builder.Property(u => u.SecurityStamp).HasMaxLength(36).IsRequired(true);
            builder.Property(u => u.ConcurrencyStamp).HasMaxLength(36).IsRequired(true);
            builder.Property(u => u.PhoneNumber).HasMaxLength(15).IsRequired(false);
            builder.Property(u => u.PhoneNumberConfirmed).IsRequired(true).HasDefaultValue(false);
            builder.Property(u => u.TwoFactorEnabled).IsRequired(true).HasDefaultValue(false);
            builder.Property(u => u.LockoutEnd).IsRequired(false);
            builder.Property(u => u.LockoutEnabled).IsRequired(true).HasDefaultValue(false);
            builder.Property(u => u.AccessFailedCount).IsRequired(true).HasDefaultValue(0);
            builder.Property(u => u.CreatedAt).ValueGeneratedOnAdd().HasDefaultValue(DateTime.UtcNow);
            builder.Property(u => u.LastModified).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.UtcNow);
        }
    }
}
