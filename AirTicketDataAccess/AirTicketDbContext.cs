﻿using AirTicketDataAccess.entities;
using Microsoft.AspNetCore.Identity;
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
    public DbSet<ClassEntity> Classes { get; set; }
    public DbSet<ClassFlightEntity> ClassFlights { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("user_claims");
        modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("user_logins").HasNoKey();
        modelBuilder.Entity<IdentityUserToken<int>>().ToTable("user_tokens").HasNoKey();
        modelBuilder.Entity<IdentityRole<int>>().ToTable("user_roles");
        modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("user_roles_claims");
        modelBuilder.Entity<IdentityUserRole<int>>().ToTable("user_role_owners").HasNoKey();
        
        modelBuilder.Entity<CountryEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<CountryEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<TownEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<TownEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<AirportEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<AirportEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<AirlineEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<AirlineEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<FlightEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<FlightEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<ClassEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<ClassEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<TicketEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<TicketEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<UserEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<UserEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<ClassFlightEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<ClassFlightEntity>().HasIndex(x => x.ExternalId).IsUnique();

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