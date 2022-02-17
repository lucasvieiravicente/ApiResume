using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiResume.Services
{
    public class KnowledgeServiceBase
    {
        private readonly IKnowledgeRepository _knowledgeRepository;
        private readonly IMapper _mapper;

        public KnowledgeServiceBase(IKnowledgeRepository knowledgeRepository, IMapper mapper)
        {
            _knowledgeRepository = knowledgeRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Knowledge>> GetAllKnowledges() => await _knowledgeRepository.GetAll();

        public async Task<IEnumerable<KnowledgeResponse>> GetAllKnowledgeResponse() => _mapper.Map<List<KnowledgeResponse>>(await _knowledgeRepository.GetAll());
    }
}
