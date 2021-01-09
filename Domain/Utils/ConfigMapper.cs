using ApiResume.Domain.Models;
using AutoMapper;

namespace ApiResume.Domain.Utils
{
    public class ConfigMapper
    {
        public static IMapper Configure()
        {
            return new MapperConfiguration(mapperConfig =>
            {
                mapperConfig.CreateMap<Knowledge, KnowledgeResponse>();
                mapperConfig.CreateMap<KnowledgeResponse, Knowledge>();
            }).CreateMapper();
        }
    }
}
