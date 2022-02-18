using ApiResume.Domain.Context;
using ApiResume.Domain.Enums;
using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<Knowledge>> GetKnowledgeByStackId(StackGroup stackId)
        {
            return await Query()
                            .Where(x => x.StackId == stackId)
                            .ToListAsync();
        }
    }
}
