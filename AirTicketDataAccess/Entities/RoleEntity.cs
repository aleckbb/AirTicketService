using System.ComponentModel.DataAnnotations.Schema;

namespace AirTicketDataAccess.entities;

[Table("Role")]
public class RoleEntity : BaseEntity
{
    public string RoleName { get; set; }

    public virtual ICollection<UserEntity>? Users { get; set; }
}