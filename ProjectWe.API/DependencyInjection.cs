using Microsoft.AspNetCore.Mvc.Infrastructure;
using ProjectWe.API.Filters;
using ProjectWe.Services;

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
            services.AddAutoMapper(typeof(IUsersService));

            return services;
        }
    }
}
