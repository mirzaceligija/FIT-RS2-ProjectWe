namespace IdentityServer.Services
{
    public interface IHostSeeder
    {
        Task AddRoles();
        Task AddUsers();
    }
}
