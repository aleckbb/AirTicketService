using AirTicketDataAccess;
using Microsoft.EntityFrameworkCore;

namespace AirTicketService.IoC;

public class DbContextConfigurator
{
    public static void ConfigureServices(WebApplicationBuilder builder)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false)
            .Build();
        var connectionString = configuration.GetValue<string>("AirTicketContext");
        builder.Services.AddDbContextFactory<AirTicketDbContext>(
            options => { options.UseNpgsql(connectionString); },
            ServiceLifetime.Scoped);
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<AirTicketDbContext>>();
        using var context = contextFactory.CreateDbContext();
        context.Database.Migrate();
    }
}