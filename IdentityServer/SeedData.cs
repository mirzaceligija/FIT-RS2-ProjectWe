﻿using IdentityModel;
using IdentityServer.Data;
using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Mappers;
using IdentityServer4.EntityFramework.Storage;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace IdentityServer;

public class SeedData
{
    public static void EnsureSeedData(string connectionString)
    {
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddDbContext<AspNetIdentityDbContext>(
            opt => opt.UseSqlServer(connectionString)
        );

        services
                .AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AspNetIdentityDbContext>()
                .AddDefaultTokenProviders();

        services.AddOperationalDbContext(
            opt =>
            {
                opt.ConfigureDbContext = db =>
                    db.UseSqlServer(
                        connectionString,
                        sql => sql.MigrationsAssembly(typeof(SeedData).Assembly.FullName)
                    );
            }
        );
        services.AddConfigurationDbContext(
            opt =>
            {
                opt.ConfigureDbContext = db =>
                    db.UseSqlServer(
                        connectionString,
                        sql => sql.MigrationsAssembly(typeof(SeedData).Assembly.FullName)
                    );
            }
        );

        var serviceProvider = services.BuildServiceProvider();

        using var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();
        scope.ServiceProvider.GetService<PersistedGrantDbContext>().Database.Migrate();

        var context = scope.ServiceProvider.GetService<ConfigurationDbContext>();
        context.Database.Migrate();

        EnsureSeedData(context);

        var ctx = scope.ServiceProvider.GetService<AspNetIdentityDbContext>();
        ctx.Database.Migrate();
        EnsureUsers(scope);
    }

    private static void EnsureUsers(IServiceScope scope)
    {
        var userMgr = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

        var admin = userMgr.FindByNameAsync("Admin").Result;
        if (admin == null)
        {
            admin = new IdentityUser
            {
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@email.com",
                NormalizedEmail = "ADMIN@EMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
            };
            var result = userMgr.CreateAsync(admin, "test").Result;
            if (!result.Succeeded)
            {
                throw new Exception(result.Errors.First().Description);
            }

            result =
                userMgr.AddClaimsAsync(
                    admin,
                    new Claim[]
                    {
                            new Claim(JwtClaimTypes.Name, "Admin Super"),
                            new Claim(JwtClaimTypes.GivenName, "Admin"),
                            new Claim(JwtClaimTypes.FamilyName, "Super"),
                            new Claim(JwtClaimTypes.WebSite, "http://admin.com"),
                            new Claim("location", "somewhere")
                    }
                ).Result;
            if (!result.Succeeded)
            {
                throw new Exception(result.Errors.First().Description);
            }
        }

        var manager = userMgr.FindByNameAsync("Manager").Result;
        if (manager == null)
        {
            manager = new IdentityUser
            {
                UserName = "Manager",
                NormalizedUserName = "MANAGER",
                Email = "manager@email.com",
                NormalizedEmail = "MANAGER@EMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
            };
            var result = userMgr.CreateAsync(manager, "test").Result;
            if (!result.Succeeded)
            {
                throw new Exception(result.Errors.First().Description);
            }

            result =
                userMgr.AddClaimsAsync(
                    manager,
                    new Claim[]
                    {
                            new Claim(JwtClaimTypes.Name, "Manager Super"),
                            new Claim(JwtClaimTypes.GivenName, "Manager"),
                            new Claim(JwtClaimTypes.FamilyName, "Super"),
                            new Claim(JwtClaimTypes.WebSite, "http://manager.com"),
                            new Claim("location", "somewhere")
                    }
                ).Result;
            if (!result.Succeeded)
            {
                throw new Exception(result.Errors.First().Description);
            }
        }
    }

    private static void EnsureSeedData(ConfigurationDbContext context)
    {
        if (!context.Clients.Any())
        {
            foreach (var client in Config.Clients.ToList())
            {
                context.Clients.Add(client.ToEntity());
            }

            context.SaveChanges();
        }

        if (!context.IdentityResources.Any())
        {
            foreach (var resource in Config.IdentityResources.ToList())
            {
                context.IdentityResources.Add(resource.ToEntity());
            }

            context.SaveChanges();
        }

        if (!context.ApiScopes.Any())
        {
            foreach (var resource in Config.ApiScopes.ToList())
            {
                context.ApiScopes.Add(resource.ToEntity());
            }

            context.SaveChanges();
        }

        if (!context.ApiResources.Any())
        {
            foreach (var resource in Config.ApiResources.ToList())
            {
                context.ApiResources.Add(resource.ToEntity());
            }

            context.SaveChanges();
        }
    }
}
