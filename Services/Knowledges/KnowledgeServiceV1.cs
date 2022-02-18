using ApiResume.Domain.BlobContext.Interfaces;
using ApiResume.Domain.Repository.Interfaces;
using ApiResume.Domain.Responses;
using ApiResume.Services.Interfaces.Knowledges;
using AutoMapper;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ApiResume.Services.Knowledges
{
    public class KnowledgeServiceV1 : KnowledgeServiceBase, IKnowledgeServiceV1
    {
        private readonly IBlobContext _blobContext;

        public KnowledgeServiceV1(IKnowledgeRepository knowledgeRepository, IBlobContext blobContext, IMapper mapper) : base(knowledgeRepository, mapper)
        {
            _blobContext = blobContext;
        }

        public async Task<byte[]> GetPhoto() => (await _blobContext.GetFile("angular.png")).ToArray();

        public async Task<IEnumerable<KnowledgeResponse>> GetAllKnowledge()
        {
            IEnumerable<KnowledgeResponse> knowledges = await GetAllKnowledgeResponse();
            foreach (KnowledgeResponse knowledge in knowledges)
            {
                MemoryStream file = await _blobContext.GetFile(knowledge.FilePathImage);
                knowledge.FileData = file.ToArray();
            }

            return knowledges;
        }
    }
}
