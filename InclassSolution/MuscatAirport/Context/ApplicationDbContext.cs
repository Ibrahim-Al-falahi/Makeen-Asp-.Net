using Microsoft.EntityFrameworkCore;
using MuscatAirport.Models.Airline_Module;
using MuscatAirport.Models.Checkpoint_Module;
using MuscatAirport.Models.Passenger_Module;
using MuscatAirport.Models.Terminal_Module;
using System.Reflection;

namespace MuscatAirport.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //}
        public DbSet<Officer> officers { get; set; }
        public DbSet<Checkpoint> checkpoints { get; set; }
        public DbSet<Terminal> terminals { get; set; }
        public DbSet<Gate> gates { get; set; }
        public DbSet<Airline> airlines { get; set; }
        public DbSet<Flight> flights { get; set; }
        public DbSet<Passenger> passengers { get; set; }
        public DbSet<Baggage> baggages { get; set; }
    }
}
