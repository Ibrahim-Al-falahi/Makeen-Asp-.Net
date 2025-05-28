using System.ComponentModel.DataAnnotations;
using MuscatAirport.Models.Terminal_Module;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuscatAirport.Models.Checkpoint_Module
{
    public class Officer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [ForeignKey("CheckpointId")]
        public Checkpoint Checkpoint { get; set; }
        public int CheckpointId { get; set; }
    }
}
