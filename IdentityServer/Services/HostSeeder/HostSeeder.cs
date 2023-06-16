using IdentityModel;
using IdentityServer.Database;
using IdentityServer.Database.Entities;
using Microsoft.AspNetCore.Identity;
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

            await GenerateUser("manager");
            await GenerateUser("manager2");
            await GenerateUser("manager3");
            await GenerateUser("manager4");
            await GenerateUser("manager5");
            await GenerateUser("manager6");
            await GenerateUser("manager7");
            await GenerateUser("manager8");
            await GenerateUser("manager9");
            await GenerateUser("manager10");
        }
        
        public async Task GenerateUser(string username)
        {
            var usr = await _userManager.FindByNameAsync(username);
            if (usr == null)
            {
                usr = new AppUser
                {
                    UserName = username,
                    NormalizedUserName = username.ToUpper(),
                    Email = $"{username}@email.com",
                    NormalizedEmail = $"{username.ToUpper()}@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    FirstName = username,
                    LastName = "Super"
                };
                var result = await _userManager.CreateAsync(usr, "Test123!");
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                var managerUserRole = new AppUserRoles
                {
                    UserId = usr.Id,
                    RoleId = 2,
                    CreatedAt = DateTime.UtcNow,
                    LastModified = null
                };

                await _context.AppUserRoles.AddAsync(managerUserRole);
                await _userManager.AddToRoleAsync(usr, "Manager");

                result =
                    await _userManager.AddClaimsAsync(
                        usr,
                        new Claim[]
                        {
                            new Claim(JwtClaimTypes.Name, usr.UserName),
                            new Claim(JwtClaimTypes.GivenName, usr.FirstName),
                            new Claim(JwtClaimTypes.FamilyName, usr.LastName),
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
