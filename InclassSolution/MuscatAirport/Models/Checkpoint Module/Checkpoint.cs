using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MuscatAirport.Models.Terminal_Module;

namespace MuscatAirport.Models.Checkpoint_Module
{
    public class Checkpoint
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TerminalName { get; set; }
        [Required]
        public int PassengerCapacity { get; set; }
        [Required]
        public string Location { get; set; }
        [ForeignKey("TerminalId")]
        public Terminal Terminal { get; set; }
        public int TerminalId { get; set; }

        public IEnumerable<Officer> OfficersList { get; set; }= new List<Officer>();
    }
}
