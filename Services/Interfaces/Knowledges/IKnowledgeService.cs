using ApiResume.Domain.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiResume.Services.Interfaces.Knowledges
{
    public interface IKnowledgeService
    {
        Task<byte[]> GetPhoto();
        Task<IEnumerable<KnowledgeResponse>> GetAllKnowledge();
    }
}
