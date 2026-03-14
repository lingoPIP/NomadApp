using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NomadApp.Data.Models;
using System.Net.Sockets;
using System.Reflection;

namespace NomadApp.Data
{
    public class NomadDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        // for debugging purposes
        public NomadDbContext()
        {
            
        }
        public NomadDbContext(DbContextOptions<NomadDbContext> options)
            : base(options)
        {
        }

        // EF Core will take care of loading the DbSet<T>
        public DbSet<Booking> Bookings { get; set; } = null!;

        public DbSet<City> Cities { get; set; } = null!;

        public DbSet<Place> Places { get; set; } = null!;

        public DbSet<TourOperator> TourOperators { get; set; } = null!;

        public DbSet<Trip> Trips { get; set; } = null!;

        public DbSet<TripCity> TripCities { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
