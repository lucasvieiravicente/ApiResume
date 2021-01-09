using Microsoft.EntityFrameworkCore;
using ApiResume.Domain.Models;

namespace ApiResume.Domain.Context
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }

        public DbSet<Knowledge> Knowledges { get; set; }
    }
}
