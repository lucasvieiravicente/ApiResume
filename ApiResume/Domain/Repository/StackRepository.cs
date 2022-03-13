using ApiResume.Domain.Context;
using ApiResume.Domain.Enums;
using ApiResume.Domain.Models;
using ApiResume.Domain.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ApiResume.Domain.Repository
{
    public class StackRepository : Repository<Stack>, IStackRepository
    {
        public StackRepository(EFContext context) : base(context) { }

        public async Task<Stack> GetStackByStackId(StackIds stackId)
        {
            return await Query().FirstOrDefaultAsync(x => x.StackId == stackId);
        }
    }
}
