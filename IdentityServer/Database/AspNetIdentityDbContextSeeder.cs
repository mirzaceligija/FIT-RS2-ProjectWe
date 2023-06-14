using IdentityServer.Services;

namespace IdentityServer.Database
{
    public static class AspNetIdentityDbContextSeeder
    {
        public static async Task SeedAsync(IHostSeeder hostSeeder)
        {
            await hostSeeder.AddRoles();
            await hostSeeder.AddUsers();
        }
    }
}
