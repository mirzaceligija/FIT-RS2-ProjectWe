using IdentityServer;

var seed = args.Contains("/seed");
if (seed)
{
    args = args.Except(new[] { "/seed" }).ToArray();
}

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddIdentityServerServices(builder.Configuration);
    if (seed)
    {
        SeedData.EnsureSeedData(builder.Configuration.GetConnectionString("DefaultConnection")!);
    }
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app
        .UseHttpsRedirection()
        .UseAuthorization();

    app.UseRouting();
    app.UseIdentityServer();
    app.UseAuthorization();
    app.MapControllers();

    app.Run();
}
