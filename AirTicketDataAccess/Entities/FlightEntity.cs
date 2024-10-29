using System.ComponentModel.DataAnnotations.Schema;

namespace AirTicketDataAccess.entities;

[Table("Flight")]
public class FlightEntity : BaseEntity
{
    public DateTime DepartureDateTime { get; set; }
    public DateTime ArrivalDateTime { get; set; }

    public int AirlineId { get; set; }
    public virtual AirlineEntity Airline { get; set; }

    public int DepartureAirportId { get; set; }
    public virtual AirportEntity DepartureAirport { get; set; }

    public int ArrivalAirportId { get; set; }
    public virtual AirportEntity ArrivalAirport { get; set; }

    public virtual ICollection<ClassFlightEntity>? Classes { get; set; }
    public virtual ICollection<TicketEntity>? Tickets { get; set; }
}