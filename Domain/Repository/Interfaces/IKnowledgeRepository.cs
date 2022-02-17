using ApiResume.Domain.Context.Interfaces;
using ApiResume.Domain.Models;
using System.Threading.Tasks;

namespace ApiResume.Domain.Repository.Interfaces
{
    public interface IKnowledgeRepository : IRepository<Knowledge>
    {
        Task<Knowledge> GetKnowledgeWithStack(string id);
    }
}
