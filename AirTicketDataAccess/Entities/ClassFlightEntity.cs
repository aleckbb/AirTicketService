using System.ComponentModel.DataAnnotations.Schema;

namespace AirTicketDataAccess.entities;

[Table("ClassFlight")]
public class ClassFlightEntity : BaseEntity
{
    public int NumberFreeSeats { get; set; }
    public double Price { get; set; }

    public int ClassId { get; set; }
    public virtual ClassEntity Class { get; set; }

    public int FlightId { get; set; }
    public virtual FlightEntity Flight { get; set; }
}