using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.OpenApi.Models;
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProjectWe API", Version = "v1" });
                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
            });
            services.AddAutoMapper(typeof(IUsersService));

            return services;
        }
    }
}
