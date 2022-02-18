using ApiResume.Domain.Models;
using ApiResume.Domain.Responses;
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
