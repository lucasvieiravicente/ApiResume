using ApiResume.Domain.Context;
using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;

namespace ApiResume.Domain.Repository
{
    public class KnowledgeRepository : Repository<Knowledge>, IKnowledgeRepository
    {
        public KnowledgeRepository(EFContext context) : base(context)
        {
        }
    }
}
