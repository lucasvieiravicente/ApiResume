using ApiResume.Domain.BlobContext.Interfaces;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace ApiResume.Domain.BlobContext
{
    public class BlobContext : IBlobContext
    {
        private readonly BlobContainerClient _blobContainerClient;
        public BlobContext(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("StorageData");
            var containerName = configuration.GetSection("BlobContainerName").Value;
            var blobContainerClient = new BlobServiceClient(connectionString);

            try
            {
                _blobContainerClient = blobContainerClient.CreateBlobContainer(containerName).Value;
            }
            catch
            {
                _blobContainerClient = blobContainerClient.GetBlobContainerClient(containerName);
            }
        }

        public async Task<MemoryStream> GetFile(string filename)
        {
            using var ms = new MemoryStream();
            var x = _blobContainerClient.GetBlobClient(filename);
            await x.DownloadToAsync(ms);
            return ms;
        }
    }
}
