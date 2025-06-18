using System.ComponentModel.DataAnnotations;

namespace Todo.DAL.Entities
{
    public class Catagory:BaseEntity
    {
        
        public string Name { get; set; }

        public IEnumerable<TodoList> TodoList { get; set; }=new HashSet<TodoList>();
    }
}
