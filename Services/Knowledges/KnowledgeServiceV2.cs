﻿using ApiResume.Domain.Enums;
using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;
using ApiResume.Domain.Responses;
using ApiResume.Services.Interfaces.Knowledges;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiResume.Services.Knowledges
{
    public class KnowledgeServiceV2 : KnowledgeServiceBase, IKnowledgeServiceV2
    {
        private readonly IKnowledgeRepository _knowledgeRepository;
        private readonly IMapper _mapper;

        public KnowledgeServiceV2(IKnowledgeRepository knowledgeRepository, IMapper mapper) : base(knowledgeRepository, mapper)
        {
            _knowledgeRepository = knowledgeRepository;
            _mapper = mapper;
        }

        public async Task<byte[]> GetPhoto() => new byte[] {};

        public async Task<IEnumerable<KnowledgeResponse>> GetAllKnowledge() => await GetAllKnowledgeResponse();

        public async Task<Knowledge> GetKnowledge(string id) => await _knowledgeRepository.GetKnowledgeWithStack(id);

        public async Task<IEnumerable<KnowledgeResponse>> GetKnowledgeByStackId(StackGroup stackId)
        {
            IEnumerable<Knowledge> knowledges = await _knowledgeRepository.GetKnowledgeByStackId(stackId);
            return _mapper.Map<IEnumerable<KnowledgeResponse>>(knowledges);
        }
    }
}
