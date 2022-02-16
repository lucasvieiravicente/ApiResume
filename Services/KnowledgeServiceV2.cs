using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;
using ApiResume.Services.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiResume.Services
{
    public class KnowledgeServiceV2 : KnowledgeServiceBase, IKnowledgeServiceV2
    {
        public KnowledgeServiceV2(IKnowledgeRepository knowledgeRepository, IMapper mapper) : base(knowledgeRepository, mapper)
        {
        }

        public async Task<byte[]> GetPhoto() => new byte[] {};

        public async Task<IEnumerable<KnowledgeResponse>> GetAllKnowledge()
        {
            IEnumerable<KnowledgeResponse> knowledges = GetAllKnowledgeResponse();

            return knowledges;
        }
    }
}
