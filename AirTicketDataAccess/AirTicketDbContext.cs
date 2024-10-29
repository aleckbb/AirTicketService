using AirTicketDataAccess.entities;
using Microsoft.EntityFrameworkCore;

namespace AirTicketDataAccess;

public class AirTicketDbContext : DbContext
{
    public AirTicketDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<CountryEntity> Countries { get; set; }
    public DbSet<TownEntity> Towns { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<TicketEntity> Tickets { get; set; }
    public DbSet<AirportEntity> Airports { get; set; }
    public DbSet<FlightEntity> Flights { get; set; }
    public DbSet<AirlineEntity> Airlines { get; set; }
    public DbSet<RoleEntity> Roles { get; set; }
    public DbSet<ClassEntity> Classes { get; set; }
    public DbSet<ClassFlightEntity> ClassFlights { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CountryEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<TownEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<AirportEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<AirlineEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<FlightEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<ClassEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<TicketEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<UserEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<RoleEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<ClassFlightEntity>().HasKey(x => x.Id);

        modelBuilder.Entity<UserEntity>().HasOne(x => x.Role)
            .WithMany(x => x.Users).HasForeignKey(x => x.RoleId);
        modelBuilder.Entity<TicketEntity>().HasOne(x => x.User)
            .WithMany(x => x.Tickets).HasForeignKey(x => x.UserId);
        modelBuilder.Entity<TicketEntity>().HasOne(x => x.Class)
            .WithMany(x => x.Tickets).HasForeignKey(x => x.ClassId);
        modelBuilder.Entity<TicketEntity>().HasOne(x => x.Flight)
            .WithMany(x => x.Tickets).HasForeignKey(x => x.FlightId);
        modelBuilder.Entity<ClassFlightEntity>().HasOne(x => x.Class)
            .WithMany(x => x.Flights).HasForeignKey(x => x.ClassId);
        modelBuilder.Entity<ClassFlightEntity>().HasOne(x => x.Flight)
            .WithMany(x => x.Classes).HasForeignKey(x => x.FlightId);
        modelBuilder.Entity<TownEntity>().HasOne(x => x.Country)
            .WithMany(x => x.Towns).HasForeignKey(x => x.CountryId);
        modelBuilder.Entity<AirportEntity>().HasOne(x => x.Town)
            .WithMany(x => x.Airports).HasForeignKey(x => x.TownId);
        modelBuilder.Entity<FlightEntity>().HasOne(x => x.DepartureAirport)
            .WithMany(x => x.FlightsLikeDepartureAirport).HasForeignKey(x => x.DepartureAirportId);
        modelBuilder.Entity<FlightEntity>().HasOne(x => x.ArrivalAirport)
            .WithMany(x => x.FlightsLikeArrivalAirport).HasForeignKey(x => x.ArrivalAirportId);
        modelBuilder.Entity<FlightEntity>().HasOne(x => x.Airline)
            .WithMany(x => x.Flights).HasForeignKey(x => x.AirlineId);
    }
}