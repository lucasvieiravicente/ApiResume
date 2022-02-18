using ApiResume.Domain.Models;
using System.Threading.Tasks;

namespace ApiResume.Services.Interfaces.Knowledges
{
    public interface IKnowledgeServiceV2 : IKnowledgeService
    {
        Task<Knowledge> GetKnowledge(string id);
    }
}
