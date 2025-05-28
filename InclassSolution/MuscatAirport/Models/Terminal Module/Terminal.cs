using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MuscatAirport.Models.Checkpoint_Module;

namespace MuscatAirport.Models.Terminal_Module
{
    public class Terminal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public string Location { get; set; }
       
        public IEnumerable<Gate> GatesList { get; set; } = new List<Gate>();
        public IEnumerable<Checkpoint> CheckpointsList { get; set; } = new List<Checkpoint>();
    }
}
