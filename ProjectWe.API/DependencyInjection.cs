using Microsoft.AspNetCore.Mvc.Infrastructure;
using ProjectWe.API.Filters;

namespace ProjectWe.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllers(config =>
            {
                config.Filters.Add<ErrorFilter>();
            });
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            //TODO: Add Automapper
            //builder.Services.AddAutoMapper(typeof(IUsersService));

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Administrator",
                authBuilder =>
                {
                    authBuilder.RequireRole("Administrator");
                });
                options.AddPolicy("Manager",
                    authBuilder =>
                    {
                        authBuilder.RequireRole("Manager");
                    });
            });

            return services;
        }
    }
}
