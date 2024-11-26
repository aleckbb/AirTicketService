namespace AirTicketService.Settings;

public class AirTicketSettings
{
    public string? AirTicketDbContextConnectionString { get; set; }
    public string? ClientId { get; set; }
    public string? ClientSecret { get; set; }
    public string? IdentityServerUri { get; set; }
}