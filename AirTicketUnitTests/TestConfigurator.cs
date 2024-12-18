using AirTicketService.Settings;
using Microsoft.Extensions.Configuration;

namespace AirTicketUnitTests;

public class TestConfigurator
{
    private static IConfiguration GetConfiguration()
    {
        return new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false)
            .Build();
    }

    public static AirTicketSettings GetSettings()
    {
        return AirTicketSettingsReader.Read(GetConfiguration());
    }
}