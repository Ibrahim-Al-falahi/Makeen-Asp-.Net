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
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public bool CatagoryExists(int id)
        {
            return _context.Catagories.Any(e => e.Id == id);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public void DeleteById(int id)
        {
            _context.Remove(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int? id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<int> SaveChangesAsyncronised()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

        
    }
}
