using IdentityServer.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer;

public static class DependencyInjection
{
    public static IServiceCollection AddIdentityServerServices(this IServiceCollection services, ConfigurationManager configuration)
    {
        services
            .AddSwaggerServices()
            .AddControllers();

        services.AddDbContext<AspNetIdentityDbContext>(opt =>
        {
            opt.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(Program).Assembly.GetName().Name)
            );
        });

        services
            .AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<AspNetIdentityDbContext>();

        services
            .AddIdentityServer()
            .AddAspNetIdentity<IdentityUser>()
            .AddConfigurationStore(opt =>
            {
                opt.ConfigureDbContext = b =>
                b.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    m => m.MigrationsAssembly(typeof(Program).Assembly.GetName().Name)
                );
            })
            .AddOperationalStore(opt =>
            {
                opt.ConfigureDbContext = b =>
                b.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    m => m.MigrationsAssembly(typeof(Program).Assembly.GetName().Name)
                );
            })
            .AddDeveloperSigningCredential();

        return services;
    }

    public static IServiceCollection AddSwaggerServices(this IServiceCollection services)
    {
        services
            .AddEndpointsApiExplorer()
            .AddSwaggerGen();

        return services;
    }
}
