using ApiResume.Domain.Context.Interfaces;
using ApiResume.Domain.Enums;
using ApiResume.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiResume.Domain.Repository.Interfaces
{
    public interface IKnowledgeRepository : IRepository<Knowledge>
    {
        Task<Knowledge> GetKnowledgeWithStack(string id);
        Task<IEnumerable<Knowledge>> GetKnowledgeByStackId(StackGroup stackId);
    }
}
