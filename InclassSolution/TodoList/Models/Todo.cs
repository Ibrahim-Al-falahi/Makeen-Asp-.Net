using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public string Priority { get; set; }
        public DateTimeOffset Deadline { get; set; }

        [ForeignKey("CatagoryId")]
        public Catagory Catagory { get; set; }
        public int CatagoryId { get; set; }
    }
}
