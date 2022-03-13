using System;
using System.IO;
using System.Threading.Tasks;

namespace ApiResume.Domain.BlobContext.Interfaces
{
    [Obsolete("Service no longer in use because personal Azure Storage is offline.")]
    public interface IBlobContext
    {
        [Obsolete("Method no longer in use because personal Azure Storage is offline.")]
        Task<MemoryStream> GetFile(string filename);
    }
}
