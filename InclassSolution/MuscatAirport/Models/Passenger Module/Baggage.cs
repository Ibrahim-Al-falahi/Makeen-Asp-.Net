using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuscatAirport.Models.Passenger_Module
{
    public class Baggage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        public int TrackingNumber { get; set; }
        [ForeignKey("PassengerId")]
        public Passenger Passenger { get; set; }
        public int PassengerId { get; set; }
    }
}
