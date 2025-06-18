using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todo.BLL.Interfaces;
using Todo.DAL.Context;
using Todo.DAL.Entities;

namespace Todo.BLL.Repositories
{
    public class TodoListRepository : GenericRepository<TodoList>, ITodoListRepository
    {
        private readonly ApplicationDbContext _context;

        public TodoListRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TodoList>> GetAllWithCategory()
        {
            return await _context.Todos.Include(t => t.Catagory).ToListAsync();
        }
        public async Task<TodoList> GetByIdWithCategory(int id)
        {
            return await _context.Todos.Include(t => t.Catagory).FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<Catagory>> GetAllCatagories()
        {
            return await _context.Catagories.ToListAsync();
        }

        public async Task<bool> TodoListExists(int id)
        {
            return await _context.Todos.AnyAsync(e => e.Id == id);
        }
    }
}
