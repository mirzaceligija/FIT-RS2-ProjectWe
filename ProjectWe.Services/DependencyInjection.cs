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
using ProjectWe.Services.Services.Activities;
using ProjectWe.Services.Services.Budgets;
using ProjectWe.Services.Services.Categories;
using ProjectWe.Services.Services.Cities;
using ProjectWe.Services.Services.Objectives;
using ProjectWe.Services.Services.Outputs;
using ProjectWe.Services.Services.Projects;
using ProjectWe.Services.Services.Reviews;
using ProjectWe.Services.Services.Roles;
using ProjectWe.Services.Services.Statuses;
using ProjectWe.Services.Services.Users;
using ProjectWe.Services.Services.Votes;
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
            services.AddTransient<IRolesService, RolesService>();
            services.AddTransient<ICitiesService, CitiesService>();
            services.AddTransient<IStatusesService, StatusesService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            services.AddTransient<IProjectsService, ProjectsService>();
            services.AddTransient<IObjectivesService, ObjectivesService>();
            services.AddTransient<IOutputsService, OutputsService>();
            services.AddTransient<IActivitiesService, ActivitiesService>();
            services.AddTransient<IBudgetsService, BudgetsService>();
            services.AddTransient<IReviewsService, ReviewsService>();
            services.AddTransient<IVotesService, VotesService>();

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

            using (var scope = services.BuildServiceProvider().CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<_160020Context>();
                WaitForDatabase(context);
                context.Database.Migrate();
            }

            return services;
        }

        private static void WaitForDatabase(_160020Context context)
        {
            var retryCount = 5;
            var delay = TimeSpan.FromSeconds(10);

            for (var i = 0; i < retryCount; i++)
            {
                try
                {
                    if (context.Database.CanConnect())
                    {
                        if (CheckTableExists(context, "AppUsers"))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("AppUsers table not found. Retry in {delay.TotalSeconds} seconds...");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to connect to the database: {ex.Message}");
                }

                Console.WriteLine($"Retry in {delay.TotalSeconds} seconds...");
                Thread.Sleep(delay);
            }
        }

        private static bool CheckTableExists(_160020Context context, string tableName)
        {
            var connection = context.Database.GetDbConnection();
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'";
            connection.Open();
            var count = (int)command.ExecuteScalar();
            connection.Close();

            return count > 0;
        }
    }
}
