using ApiResume.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiResume.Domain.Context.EntityMaps
{
    public static class ModelMaps
    {
        public static void CreateKnowledgeMap(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Knowledge>()
                                    .HasOne(x => x.Stack)
                                    .WithMany(x => x.Knowledges)
                                    .HasForeignKey(x => x.StackId);
        }

        public static void CreateStackMap(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stack>()
                                    .HasMany(x => x.Knowledges)
                                    .WithOne(x => x.Stack)
                                    .HasPrincipalKey(x => x.StackId);
        }
    }
}
