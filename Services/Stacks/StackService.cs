using ApiResume.Domain.Enums;
using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;
using ApiResume.Domain.Responses;
using ApiResume.Services.Interfaces.Stacks;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiResume.Services.Stacks
{
    public class StackService : IStackService
    {
        private readonly IMapper _mapper;
        private readonly IStackRepository _stackRepository;

        public StackService(IMapper mapper, IStackRepository stackRepository)
        {
            _mapper = mapper;
            _stackRepository = stackRepository;
        }

        public async Task<StackResponse> GetStackByStackId(StackIds stackId)
        {
            return _mapper.Map<StackResponse>(await _stackRepository.GetStackByStackId(stackId));
        }

        public async Task<IEnumerable<StackResponse>> GetAll()
        {
            IEnumerable<Stack> stacks = await _stackRepository.GetAll();
            return _mapper.Map<IEnumerable<StackResponse>>(stacks.OrderBy(x => x.StackId));
        }
    }
}
