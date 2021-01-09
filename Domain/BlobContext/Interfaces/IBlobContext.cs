using System.IO;
using System.Threading.Tasks;

namespace ApiResume.Domain.BlobContext.Interfaces
{
    public interface IBlobContext
    {
        Task<MemoryStream> GetFile(string filename);
    }
}
