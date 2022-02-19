using ApiResume.Domain.Enums;
using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;
using ApiResume.Domain.Responses;
using ApiResume.Services.Interfaces;
using ApiResume.Services.Interfaces.Knowledges;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiResume.Services.Knowledges
{
    public class KnowledgeServiceV2 : KnowledgeServiceBase, IKnowledgeServiceV2
    {
        private readonly IMapper _mapper;
        private readonly IKnowledgeRepository _knowledgeRepository;
        private readonly IFTPService _ftpService;

        public KnowledgeServiceV2(IKnowledgeRepository knowledgeRepository, IMapper mapper, IFTPService ftpService) : base(knowledgeRepository, mapper)
        {
            _knowledgeRepository = knowledgeRepository;
            _mapper = mapper;
            _ftpService = ftpService;
        }

        public async Task<byte[]> GetPhoto() => await _ftpService.GetImage("bootstrap.png");

        public async Task<IEnumerable<KnowledgeResponse>> GetAllKnowledge()
        {
            IEnumerable<KnowledgeResponse> knowledges = await GetAllKnowledgeResponse();
            await SetImagesOnKnowledgesResponses(knowledges);

            return knowledges;
        }

        public async Task<Knowledge> GetKnowledge(string id) => await _knowledgeRepository.GetKnowledgeWithStack(id);

        public async Task<IEnumerable<KnowledgeResponse>> GetKnowledgeByStackId(StackIds stackId)
        {
            IEnumerable<Knowledge> knowledges = await _knowledgeRepository.GetKnowledgeByStackId(stackId);
            var knowledgesResponses = _mapper.Map<IEnumerable<KnowledgeResponse>>(knowledges);

            await SetImagesOnKnowledgesResponses(knowledgesResponses);

            return knowledgesResponses;
        }

        private async Task SetImagesOnKnowledgesResponses(IEnumerable<KnowledgeResponse> knowledges)
        {
            IEnumerable<KeyValuePair<string, Task<byte[]>>> files = knowledges.Select(knowledge =>
            {
                string fileImage = knowledge.FilePathImage;
                return new KeyValuePair<string, Task<byte[]>>(fileImage, _ftpService.GetImage(fileImage));
            });

            await Task.WhenAll(files.Select(x => x.Value));

            foreach (var file in files)
                knowledges.FirstOrDefault(x => x.FilePathImage == file.Key).FileData = await file.Value;
        }
    }
}
