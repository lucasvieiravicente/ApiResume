using ApiResume.Domain.Models;
using AutoMapper;

namespace ApiResume.Domain.Utils
{
    public class ConfigMapper : Profile
    {
        public ConfigMapper()
        {
            CreateMap<Knowledge, KnowledgeResponse>();
            CreateMap<KnowledgeResponse, Knowledge>();
        }
    }
}
