using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MuscatAirport.Models.Terminal_Module;
using MuscatAirport.Models.Checkpoint_Module;
using MuscatAirport.Models.Passenger_Module;

namespace MuscatAirport.Models.Airline_Module
{
    public class Flight
    {
        [Key] // Primary key
        public int Id { get; set; }

        [Required]
        public string Departure { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        public DateTimeOffset DepartureTime { get; set; }

        [Required]
        public DateTimeOffset ArrivalTime { get; set; }

        [ForeignKey("AirlineId")] // Foreign Key 
        public Airline Airline { get; set; }
        public int AirlineId { get; set; }

        public IEnumerable<Passenger> PassengersList { get; set; } = new List<Passenger>();
    }
}
