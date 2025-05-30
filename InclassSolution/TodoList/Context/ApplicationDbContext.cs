using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
    }
}
