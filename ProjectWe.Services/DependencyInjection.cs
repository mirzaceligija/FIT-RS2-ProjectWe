using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Tokens;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            ConfigurationManager configuration)
        {
            services
                .AddAppServices()
                .AddIdentityConfiguration()
                .AddIdentityAuthentication(configuration)
                .AddIdentityAuthorization(configuration)
                .AddDatabaseContext(configuration);

            return services;
        }

        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<ICitiesService, CitiesService>();
            services.AddTransient<IStatusesService, StatusesService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            services.AddTransient<IProjectsService, ProjectsService>();
            services.AddTransient<IObjectivesService, ObjectivesService>();
            services.AddTransient<IOutputsService, OutputsService>();
            services.AddTransient<IActivitiesService, ActivitiesService>();
            services.AddTransient<IBudgetsService, BudgetsService>();

            return services;
        }

        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services)
        {
            services
                .AddIdentityCore<AppUser>(opt => {
                    opt.Password.RequireDigit = false;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequireUppercase = false;
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.Password.RequiredLength = 4;
                    opt.User.RequireUniqueEmail = true;
                    opt.SignIn.RequireConfirmedEmail = false;
                })
                .AddRoles<AppRole>()
                .AddRoleManager<RoleManager<AppRole>>()
                .AddSignInManager<SignInManager<AppUser>>()
                .AddRoleValidator<RoleValidator<AppRole>>()
                .AddEntityFrameworkStores<_160020Context>()
                .AddDefaultTokenProviders();

            return services;
        }

        public static IServiceCollection AddIdentityAuthentication(this IServiceCollection services, ConfigurationManager configuration)
        {
            var jwtSettings = new JwtSettings();
            configuration.Bind(JwtSettings.SectionName, jwtSettings);

            services.AddSingleton(Options.Create(jwtSettings));
            services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();

            services.AddAuthentication(cfg =>
            {
                cfg.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                cfg.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
               .AddJwtBearer(options =>
               {
                   options.RequireHttpsMetadata = false;
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidateLifetime = true,
                       ValidateIssuerSigningKey = true,
                       ValidIssuer = jwtSettings.Issuer,
                       ValidAudience = jwtSettings.Audience,
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret))
                   };
               });

            IdentityModelEventSource.ShowPII = true;

            return services;
        }

        public static IServiceCollection AddIdentityAuthorization(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddAuthorization(opt =>
            {
                opt.AddPolicy("RequireAdmin", policy =>
                {
                    policy.RequireRole("Admin");
                });
            });

            return services;
        }

        public static IServiceCollection AddDatabaseContext(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<_160020Context>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    m => m.MigrationsAssembly("ProjectWe.Services")));

            var context = services.BuildServiceProvider().GetRequiredService<_160020Context>();
            context.Database.Migrate();

            return services;
        }
    }
}
