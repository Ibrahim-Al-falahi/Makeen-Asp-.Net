using System.ComponentModel.DataAnnotations;
using MuscatAirport.Models.Terminal_Module;
using System.ComponentModel.DataAnnotations.Schema;
using MuscatAirport.Models.Airline_Module;

namespace MuscatAirport.Models.Passenger_Module
{
    public class Passenger
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTimeOffset DOB { get; set; }
        [Required]
        public char Gender { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public int PassportNumber { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [ForeignKey("FlightId")]
        public Flight Flight { get; set; }
        public int FlightId { get; set; }

        public IEnumerable<Baggage> BaggagesList { get; set; } = new List<Baggage>();
    }
}
