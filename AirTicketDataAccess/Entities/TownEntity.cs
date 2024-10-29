using System.ComponentModel.DataAnnotations.Schema;

namespace AirTicketDataAccess.entities;

[Table("Town")]
public class TownEntity : BaseEntity
{
    public string TownName { get; set; }

    public int CountryId { get; set; }
    public virtual CountryEntity Country { get; set; }

    public virtual ICollection<AirportEntity>? Airports { get; set; }
}