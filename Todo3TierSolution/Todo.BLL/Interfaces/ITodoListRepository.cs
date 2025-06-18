using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.DAL.Entities;

namespace Todo.BLL.Interfaces
{
    public interface ITodoListRepository:IGenericRepository<TodoList>
    {
        Task<IEnumerable<TodoList>> GetAllWithCategory();
        Task<TodoList> GetByIdWithCategory(int id);
        Task<IEnumerable<Catagory>> GetAllCatagories();
        Task<bool> TodoListExists(int id);
    }
}
