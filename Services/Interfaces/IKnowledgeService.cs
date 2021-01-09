using ApiResume.Domain.Models;
using System.Collections.Generic;

namespace ApiResume.Services.Interfaces
{
    public interface IKnowledgeService
    {
        IEnumerable<KnowledgeResponse> GetAllKnowledge();
    }
}
