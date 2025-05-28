using System.ComponentModel.DataAnnotations;
using MuscatAirport.Models.Checkpoint_Module;
using MuscatAirport.Models.Terminal_Module;

namespace MuscatAirport.Models.Airline_Module
{
    public class Airline
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required] // Name cannot be null or empty
        [Length(50, 100)] // Min and Max length of char in a string
        public string Name { get; set; }

        [Required]
        public int ContactNumber { get; set; }

        [Required]
        [EmailAddress] // Email address format ( 123@123.com )
        public string Email { get; set; }

        [Required]
        [MinLength(3)] // the string must be at least 3 chars
        public string Representer { get; set; }

        public IEnumerable<Gate> GatesList { get; set; } = new List<Gate>();
        public IEnumerable<Flight> FlightsList { get; set; } = new List<Flight>();
    }
}
