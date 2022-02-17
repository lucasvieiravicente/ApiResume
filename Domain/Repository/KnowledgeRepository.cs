using ApiResume.Domain.Context;
using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ApiResume.Domain.Repository
{
    public class KnowledgeRepository : Repository<Knowledge>, IKnowledgeRepository
    {
        public KnowledgeRepository(EFContext context) : base(context) { }

        public async Task<Knowledge> GetKnowledgeWithStack(string id)
        {
            return await Query()
                            .Include(x => x.Stack)
                            .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
