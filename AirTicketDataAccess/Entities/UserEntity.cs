using System.ComponentModel.DataAnnotations.Schema;

namespace AirTicketDataAccess.entities;

[Table("User")]
public class UserEntity : BaseEntity
{
    public string UserName { get; set; }
    public string UserSurname { get; set; }
    public string Email { get; set; }
    public string UserPatronymic { get; set; }
    public string PasswordHash { get; set; }

    public int RoleId { get; set; }
    public virtual RoleEntity Role { get; set; }

    public virtual ICollection<TicketEntity>? Tickets { get; set; }
}