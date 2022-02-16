using ApiResume.Domain.BlobContext.Interfaces;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ApiResume.Domain.BlobContext
{
    public class BlobContext : IBlobContext
    {
        private readonly BlobContainerClient _blobContainerClient;
        public BlobContext(IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("StorageData");
            string containerName = configuration.GetSection("BlobContainerName").Value;

            if(string.IsNullOrWhiteSpace(connectionString))
                throw new NullReferenceException("Não foi localizado o valor de conexão para o Storage.");

            if (string.IsNullOrWhiteSpace(containerName))
                throw new NullReferenceException("Não foi localizado o valor do nome do container.");

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
            BlobClient blobClient = _blobContainerClient.GetBlobClient(filename);
            await blobClient.DownloadToAsync(ms);
            return ms;
        }
    }
}
