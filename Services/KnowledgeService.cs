using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;
using ApiResume.Services.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiResume.Services
{
    public class KnowledgeService : IKnowledgeService
    {
        private readonly IKnowledgeRepository _knowledgeRepository;
        private readonly IMapper _mapper;

        public KnowledgeService(IKnowledgeRepository knowledgeRepository, IMapper mapper)
        {
            _knowledgeRepository = knowledgeRepository;
            _mapper = mapper;
        }

        public IEnumerable<KnowledgeResponse> GetAllKnowledge()
        {
            return _mapper.Map<IEnumerable<KnowledgeResponse>>(_knowledgeRepository.GetAll());
        }
    }
}
