using ApiResume.Domain.BlobContext.Interfaces;
using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;
using ApiResume.Services.Interfaces;
using AutoMapper;
using System.Collections.Generic;

namespace ApiResume.Services
{
    public class KnowledgeService : IKnowledgeService
    {
        private readonly IKnowledgeRepository _knowledgeRepository;
        private readonly IBlobContext _blobContext;
        private readonly IMapper _mapper;

        public KnowledgeService(IKnowledgeRepository knowledgeRepository, IBlobContext blobContext, IMapper mapper)
        {
            _knowledgeRepository = knowledgeRepository;
            _blobContext = blobContext;
            _mapper = mapper;
        }

        public IEnumerable<KnowledgeResponse> GetAllKnowledge()
        {
            var knowledges = _mapper.Map<List<KnowledgeResponse>>(_knowledgeRepository.GetAll());
            SetImages(knowledges);
            return knowledges;
        }

        private void SetImages(List<KnowledgeResponse> knowledges)
        {
            knowledges.ForEach(async knowledge => 
            {
                var file = await _blobContext.GetFile(knowledge.FilePathImage);
                knowledge.FileData = file.ToArray();
            });
        }
    }
}
