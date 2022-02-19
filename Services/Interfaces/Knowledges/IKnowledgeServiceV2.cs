using ApiResume.Domain.Enums;
using ApiResume.Domain.Models;
using ApiResume.Domain.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiResume.Services.Interfaces.Knowledges
{
    public interface IKnowledgeServiceV2 : IKnowledgeService
    {
        Task<Knowledge> GetKnowledge(string id);
        Task<IEnumerable<KnowledgeResponse>> GetKnowledgeByStackId(StackIds stackId);
    }
}
