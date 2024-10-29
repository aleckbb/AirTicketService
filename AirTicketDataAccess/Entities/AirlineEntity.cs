using System.ComponentModel.DataAnnotations.Schema;

namespace AirTicketDataAccess.entities;

[Table("Airline")]
public class AirlineEntity : BaseEntity
{
    public string AirlineName { get; set; }

    public virtual ICollection<FlightEntity>? Flights { get; set; }
}