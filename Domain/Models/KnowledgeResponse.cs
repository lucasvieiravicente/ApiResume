using ApiResume.Domain.Enums;

namespace ApiResume.Domain.Models
{
    public class KnowledgeResponse
    {
        public string Title { get; set; }
        public string FirstDescription { get; set; }
        public string SecondDescription { get; set; }
        public string FilePathImage { get; set; }
        public byte[] FileData { get; set; }
        public StackGroup StackId { get; set; }
    }
}
