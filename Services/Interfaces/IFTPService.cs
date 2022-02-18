using System.Threading.Tasks;

namespace ApiResume.Services.Interfaces
{
    public interface IFTPService
    {
        Task<byte[]> GetImage(string fileName);
    }
}
