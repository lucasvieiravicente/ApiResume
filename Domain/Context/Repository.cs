using ApiResume.Domain.Context.Interfaces;
using System.Collections.Generic;
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

        public virtual async Task Delete(T entity)
        {
            _context.Remove(entity);
            await Commit();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
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

        private async Task Commit() => await _context.SaveChangesAsync();
    }
}
