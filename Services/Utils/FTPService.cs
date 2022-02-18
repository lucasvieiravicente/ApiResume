using ApiResume.Services.Interfaces;
using FluentFTP;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ApiResume.Services.Utils
{
    public class FTPService : IFTPService
    {
        private readonly string _host;
        private readonly string _user;
        private readonly string _password;
        private readonly ILogger<FTPService> _logger;

        public FTPService(IConfiguration configuration, ILogger<FTPService> logger)
        {
            IConfigurationSection section = configuration.GetSection("Ftp");
            _host = section.GetSection("FtpHost").Value;
            _user = section.GetSection("FtpUser").Value;
            _password = section.GetSection("FtpPassword").Value;
            _logger = logger;
        }

        public async Task<byte[]> GetImage(string fileName)
        {
            try
            {
                var client = new FtpClient(_host, _user, _password) { ValidateAnyCertificate = true };
                await client.AutoConnectAsync();

                using var stream = new MemoryStream();
                if (!await client.DownloadAsync(stream, fileName))
                    _logger.LogInformation($"Não foi possível fazer o download do arquivo {fileName}");

                await client.DisconnectAsync();

                return stream.ToArray();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }

        }
    }
}
