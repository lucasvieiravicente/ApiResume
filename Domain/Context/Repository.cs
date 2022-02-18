using ApiResume.Domain.Context.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiResume.Domain.Context
{
    public class Repository<T> : IRepository<T> where T : EntityBase, new()
    {
        protected readonly EFContext _context;

        public Repository(EFContext context)
        {
            _context = context;
        }

        public virtual async Task<IEnumerable<T>> GetAll() => await Query().ToListAsync();

        public virtual async Task Delete(T entity)
        {
            _context.Remove(entity);
            await Commit();
        }

        public virtual async Task Insert(T entity)
        {
            _context.Add(entity);
            await Commit();
        }

        public virtual async Task Update(T entity)
        {
            _context.Update(entity);
            await Commit();
        }

        protected IQueryable<T> Query() => _context.Set<T>().AsQueryable();

        private async Task Commit() => await _context.SaveChangesAsync();
    }
}
