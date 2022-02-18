using ApiResume.Domain.Context.Interfaces;
using ApiResume.Domain.Enums;
using ApiResume.Domain.Models;
using System.Threading.Tasks;

namespace ApiResume.Domain.Repository.Interfaces
{
    public interface IStackRepository : IRepository<Stack>
    {
        Task<Stack> GetStackPerStackId(StackGroup stackId);
    }
}
