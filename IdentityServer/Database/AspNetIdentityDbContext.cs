using IdentityServer.Database.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Database;

public class AspNetIdentityDbContext : IdentityDbContext<AppUser, AppRole, int,
        IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
{
    public AspNetIdentityDbContext(DbContextOptions<AspNetIdentityDbContext> options)
        : base(options)
    {
        
    }

    public virtual DbSet<AppUser> AppUsers { get; set; } = null!;
    public virtual DbSet<AppRole> AppRoles { get; set; } = null!;
    public virtual DbSet<AppUserRoles> AppUserRoles { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AspNetIdentityDbContext).Assembly);
    }
}
