using ApiResume.Domain.Models;
using System.Threading.Tasks;

namespace ApiResume.Services.Interfaces
{
    public interface IKnowledgeServiceV2 : IKnowledgeService
    {
        Task<Knowledge> GetKnowledge(string id);
    }
}
