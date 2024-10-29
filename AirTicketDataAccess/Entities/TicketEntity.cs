using System.ComponentModel.DataAnnotations.Schema;

namespace AirTicketDataAccess.entities;

[Table("Ticket")]
public class TicketEntity : BaseEntity
{
    public int Row { get; set; }
    public int Seat { get; set; }

    public int ClassId { get; set; }
    public virtual ClassEntity Class { get; set; }

    public int UserId { get; set; }
    public virtual UserEntity User { get; set; }

    public int FlightId { get; set; }
    public virtual FlightEntity Flight { get; set; }
}