using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MuscatAirport.Models.Airline_Module;

namespace MuscatAirport.Models.Terminal_Module
{
    public class Gate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public bool Availability { get; set; }
        [ForeignKey("AirlineId")]
        public Airline Airline { get; set; }
        public int AirlineId { get; set; }
        [ForeignKey("TerminalId")]
        public Terminal Terminal { get; set; }
        public int TerminalId { get; set; }
    }
}
