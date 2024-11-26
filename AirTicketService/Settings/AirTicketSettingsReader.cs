namespace AirTicketService.Settings;

public static class AirTicketSettingsReader
{
    public static AirTicketSettings Read(IConfiguration configuration)
    {
        return new AirTicketSettings
        {
            AirTicketDbContextConnectionString = configuration.GetValue<string>("AirTicketDbContext"),
            ClientId = configuration.GetValue<string>("IdentityServerSettings:ClientId"),
            ClientSecret = configuration.GetValue<string>("IdentityServerSettings:ClientSecret"),
            IdentityServerUri = configuration.GetValue<string>("IdentityServerSettings:Uri")
        };
    }
}