using ApiResume.Domain.Enums;
using ApiResume.Domain.Repository.Interfaces;
using ApiResume.Domain.Responses;
using ApiResume.Services.Interfaces.Stacks;
using AutoMapper;
using System.Collections.Generic;
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

        public async Task<StackResponse> GetStackByStackId(StackGroup stackId)
        {
            return _mapper.Map<StackResponse>(await _stackRepository.GetStackByStackId(stackId));
        }

        public async Task<IEnumerable<StackResponse>> GetAll()
        {
            return _mapper.Map<IEnumerable<StackResponse>>(await _stackRepository.GetAll());
        }
    }
}
