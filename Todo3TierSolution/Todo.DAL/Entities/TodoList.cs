using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Todo.DAL.Entities.Enums;

namespace Todo.DAL.Entities
{
    public class TodoList : BaseEntity
    {
        
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public Priority Priority { get; set; }
        public DateTime Deadline { get; set; }

        [ForeignKey("CatagoryId")]
        public Catagory Catagory { get; set; }
        public int CatagoryId { get; set; }
    }
}
