using ApiResume.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace ApiResume.Services.Utils
{
    public class FTPService : IFTPService
    {
        private string _host;
        private string _directory;
        private string _user;
        private string _password;

        public FTPService(IConfiguration configuration)
        {
            _host = configuration.GetConnectionString("FtpHost");
            _directory = configuration.GetSection("FtpDirectory").Value;
            _user = configuration.GetSection("FtpUser").Value;
            _password = configuration.GetSection("FtpPassword").Value;
        }

        public async Task<byte[]> GetImage(string fileName)
        {
            string uri = $"{_host}/{_directory}/{fileName}";
            var request = WebRequest.Create(uri) as FtpWebRequest;

            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential(_user, _password);

            var response = await request.GetResponseAsync() as FtpWebResponse;
            var stream = response.GetResponseStream() as MemoryStream;

            return stream.ToArray();
        }
    }
}
