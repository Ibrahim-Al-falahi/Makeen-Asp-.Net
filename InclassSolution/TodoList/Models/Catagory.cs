using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Catagory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Todo> TodoList { get; set; }=new List<Todo>();
    }
}
