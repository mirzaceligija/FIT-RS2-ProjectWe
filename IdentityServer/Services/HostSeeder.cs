using IdentityModel;
using IdentityServer.Database;
using IdentityServer.Database.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityServer.Services
{
    public class HostSeeder : IHostSeeder
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly AspNetIdentityDbContext _context;

        public HostSeeder(
            RoleManager<AppRole> roleManager,
            UserManager<AppUser> userManager,
            AspNetIdentityDbContext context
        )
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }

        public async Task AddRoles()
        {
            var roles = new[] { "Admin", "Manager" };

            foreach( var role in roles)
            {
                var roleExist = await _roleManager.RoleExistsAsync(role);
                if (!roleExist)
                {
                    var newRole = new AppRole
                    {
                        Name = role,
                        NormalizedName = role.ToUpper(),
                    };
                    await _roleManager.CreateAsync(newRole);
                }
            }

        }

        public async Task AddUsers()
        {
            var admin = await _userManager.FindByNameAsync("Admin");
            if (admin == null)
            {
                admin = new AppUser
                {
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@email.com",
                    NormalizedEmail = "ADMIN@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    FirstName = "Admin",
                    LastName = "Super"
                };
                var result = await _userManager.CreateAsync(admin, "Test123!");
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                var adminUserRole = new AppUserRoles
                {
                    UserId = admin.Id,
                    RoleId = 1,
                    CreatedAt = DateTime.UtcNow,
                    LastModified = null
                };

                await _context.AppUserRoles.AddAsync(adminUserRole);
                await _userManager.AddToRoleAsync(admin, "Admin");


                result =
                    await _userManager.AddClaimsAsync(
                        admin,
                        new Claim[]
                        {
                            new Claim(JwtClaimTypes.Name, "Admin Super"),
                            new Claim(JwtClaimTypes.GivenName, "Admin"),
                            new Claim(JwtClaimTypes.FamilyName, "Super"),
                            new Claim(JwtClaimTypes.WebSite, "http://admin.com"),
                            new Claim("location", "somewhere")
                        }
                    );

                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }
            }

            var manager = await  _userManager.FindByNameAsync("Manager");
            if (manager == null)
            {
                manager = new AppUser
                {
                    UserName = "Manager",
                    NormalizedUserName = "MANAGER",
                    Email = "manager@email.com",
                    NormalizedEmail = "MANAGER@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    FirstName = "Manager",
                    LastName = "Super"
                };
                var result = await _userManager.CreateAsync(manager, "Test123!");
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                var managerUserRole = new AppUserRoles
                {
                    UserId = manager.Id,
                    RoleId = 2,
                    CreatedAt = DateTime.UtcNow,
                    LastModified = null
                };

                await _context.AppUserRoles.AddAsync(managerUserRole);
                await _userManager.AddToRoleAsync(manager, "Manager");

                result =
                    await _userManager.AddClaimsAsync(
                        manager,
                        new Claim[]
                        {
                            new Claim(JwtClaimTypes.Name, "Manager Super"),
                            new Claim(JwtClaimTypes.GivenName, "Manager"),
                            new Claim(JwtClaimTypes.FamilyName, "Super"),
                            new Claim(JwtClaimTypes.WebSite, "http://manager.com"),
                            new Claim("location", "somewhere")
                        }
                    );

                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }
            }
        }
    }
}
