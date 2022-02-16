using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;
using AutoMapper;
using System.Collections.Generic;

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

        public IEnumerable<Knowledge> GetAllKnowledges() => _knowledgeRepository.GetAll();

        public IEnumerable<KnowledgeResponse> GetAllKnowledgeResponse() => _mapper.Map<List<KnowledgeResponse>>(_knowledgeRepository.GetAll());
    }
}
