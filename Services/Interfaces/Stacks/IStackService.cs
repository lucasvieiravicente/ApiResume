using ApiResume.Domain.Enums;
using ApiResume.Domain.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiResume.Services.Interfaces.Stacks
{
    public interface IStackService
    {
        Task<StackResponse> GetStackPerStackId(StackGroup stackId);
        Task<IEnumerable<StackResponse>> GetAll();
    }
}
