namespace AirTicketService.Controllers.Entities.UserEntities;

public class UserFilter
{
    public string? NamePart { get; set; }
    public string? EmailPart { get; set; }

    public DateTime? CreationTime { get; set; }
    public DateTime? ModificationTime { get; set; }

    public int? Role { get; set; }
}