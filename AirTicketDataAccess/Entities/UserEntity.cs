using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AirTicketDataAccess.entities;

[Table("User")]
public class UserEntity : IdentityUser<int>, IBaseEntity
{
    public Guid ExternalId { get; set; }
    public DateTime ModificationTime { get; set; }
    public DateTime CreationTime { get; set; }
    public string UserName { get; set; }
    public string UserSurname { get; set; }
    public string Email { get; set; }
    public string UserPatronymic { get; set; }
    public string PasswordHash { get; set; }
    public virtual ICollection<TicketEntity>? Tickets { get; set; }
}

public class UserRole : IdentityRole<int>
{
}