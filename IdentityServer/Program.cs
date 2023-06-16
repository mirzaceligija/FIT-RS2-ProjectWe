using IdentityServer;
using IdentityServer.Database;
using IdentityServer.Services;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddPresentation(builder.Configuration);
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseIdentityServer();
    app.MapControllers();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var retryCount = 5;
    var delay = TimeSpan.FromSeconds(10);

    for (var i = 0; i < retryCount; i++)
    {
        try
        {
            var context = services.GetRequiredService<AspNetIdentityDbContext>();
            await context.Database.EnsureCreatedAsync();
            var hostSeeder = services.GetRequiredService<IHostSeeder>();
            await AspNetIdentityDbContextSeeder.SeedAsync(hostSeeder);
            break; // Success, exit the loop
        }
        catch (Exception ex)
        {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, $"An error occurred while migrating or seeding the database.|{ex.InnerException?.ToString() ?? ex.Message}");

            if (i < retryCount - 1)
            {
                Console.WriteLine($"Retry in {delay.TotalSeconds} seconds...");
                await Task.Delay(delay);
            }
            else
            {
                // Reached maximum retry count, handle the error or throw an exception
                // if desired
                Console.WriteLine("Exceeded maximum retry attempts.");
                throw;
            }
        }
    }
}

app.Run();
