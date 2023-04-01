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
    public class AppUserRolesConfigurations : IEntityTypeConfiguration<AppUserRoles>
    {
        public void Configure(EntityTypeBuilder<AppUserRoles> builder)
        {
            ConfigureUserRolesTable(builder);
            SeedUserRoles(builder);
        }

        public void ConfigureUserRolesTable(EntityTypeBuilder<AppUserRoles> builder)
        {
            builder.ToTable("AppUserRoles");
            builder.Property(u => u.CreatedAt).ValueGeneratedOnAdd().HasDefaultValue(DateTime.UtcNow);
            builder.Property(u => u.LastModified).ValueGeneratedOnAddOrUpdate().HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(d => d.AppUser)
                .WithMany(p => p.AppUserRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppUserRoles_UserId");

            builder.HasOne(d => d.AppRole)
                .WithMany(p => p.AppUserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppUserRoles_RoleId");
        }

        public void SeedUserRoles(EntityTypeBuilder<AppUserRoles> builder)
        {
            builder.HasData(
                new AppUserRoles { UserId = 1, RoleId = 1, CreatedAt = DateTime.UtcNow, LastModified = null },
                new AppUserRoles { UserId = 1, RoleId = 2, CreatedAt = DateTime.UtcNow, LastModified = null },
                new AppUserRoles { UserId = 2, RoleId = 2, CreatedAt = DateTime.UtcNow, LastModified = null });
        }
    }
}