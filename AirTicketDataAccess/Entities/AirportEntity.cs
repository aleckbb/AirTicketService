using System.ComponentModel.DataAnnotations.Schema;

namespace AirTicketDataAccess.entities;

[Table("Airport")]
public class AirportEntity : BaseEntity
{
    public string AirportName { get; set; }

    public int TownId { get; set; }
    public virtual TownEntity Town { get; set; }

    public virtual ICollection<FlightEntity>? FlightsLikeDepartureAirport { get; set; }
    public virtual ICollection<FlightEntity>? FlightsLikeArrivalAirport { get; set; }
}