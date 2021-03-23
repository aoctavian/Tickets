using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Data;

namespace Tickets
{
    public class EntityFrameworkRepository<T> : IDatabaseRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        protected DbSet<T> _dbSet;

        public EntityFrameworkRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public AppDbContext AppContext
        {
            get { return _context; }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task InsertAsync(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
