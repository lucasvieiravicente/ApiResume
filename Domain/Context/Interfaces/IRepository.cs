using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiResume.Domain.Context.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<IEnumerable<T>> GetAll();
        Task Delete(T entity);
        Task Insert(T entity);
        Task Update(T entity);
    }
}
