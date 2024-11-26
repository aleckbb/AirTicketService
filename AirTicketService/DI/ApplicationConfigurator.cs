using AirTicketService.IoC;
using AirTicketService.Settings;

namespace AirTicketService.DI;

public static class ApplicationConfigurator
{
    public static void ConfigureServices(WebApplicationBuilder builder, AirTicketSettings airTicketSettings)
    {
        DbContextConfigurator.ConfigureServices(builder);
        SerilogConfigurator.ConfigureService(builder);
        SwaggerConfigurator.ConfigureServices(builder.Services);
        MapperConfigurator.ConfigureServices(builder);
        ServicesConfigurator.ConfigureServices(builder.Services, airTicketSettings);
        AuthorizationConfigurator.ConfigureServices(builder.Services, airTicketSettings);
        
        builder.Services.AddControllers();
    }

    public static void ConfigureApplication(WebApplication app)
    {
        SerilogConfigurator.ConfigureApplication(app);
        SwaggerConfigurator.ConfigureApplication(app);
        DbContextConfigurator.ConfigureApplication(app);
        AuthorizationConfigurator.ConfigureApplication(app);
        
        app.UseHttpsRedirection();
        app.MapControllers();
    }
}