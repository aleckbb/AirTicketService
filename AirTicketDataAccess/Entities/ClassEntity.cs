using System.ComponentModel.DataAnnotations.Schema;

namespace AirTicketDataAccess.entities;

[Table("Class")]
public class ClassEntity : BaseEntity
{
    public string ClassName { get; set; }

    public virtual ICollection<ClassFlightEntity>? Flights { get; set; }
    public virtual ICollection<TicketEntity>? Tickets { get; set; }
}