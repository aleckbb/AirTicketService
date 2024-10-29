using System.ComponentModel.DataAnnotations.Schema;

namespace AirTicketDataAccess.entities;

[Table("Country")]
public class CountryEntity : BaseEntity
{
    public string CountryName { get; set; }

    public virtual ICollection<TownEntity>? Towns { get; set; }
}