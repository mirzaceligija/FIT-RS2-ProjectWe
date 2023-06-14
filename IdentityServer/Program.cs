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
    app.UseRouting();
    app.UseIdentityServer();
    app.UseAuthorization();
    app.MapControllers();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var context = services.GetRequiredService<AspNetIdentityDbContext>();
        await context.Database.EnsureCreatedAsync();
        var hostSeeder = services.GetRequiredService<IHostSeeder>();
        await AspNetIdentityDbContextSeeder.SeedAsync(hostSeeder);
    }
    catch (Exception ex)
    {
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, $"An error occurred while migrating or seeding the database.|{ex.InnerException?.ToString() ?? ex.Message}");
    }
}

app.Run();
