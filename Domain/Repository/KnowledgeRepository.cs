using ApiResume.Domain.Context;
using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiResume.Domain.Repository
{
    public class KnowledgeRepository : Repository<Knowledge>, IKnowledgeRepository
    {
        public KnowledgeRepository(EFContext context) : base(context)
        {
        }
    }
}
