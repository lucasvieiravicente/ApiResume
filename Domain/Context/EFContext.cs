using Microsoft.EntityFrameworkCore;
using ApiResume.Domain.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Reflection;
using System.Text;

namespace ApiResume.Domain.Context
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedTables(modelBuilder);
        }

        protected virtual void SeedTables(ModelBuilder modelBuilder)
        {
            var separate = Path.DirectorySeparatorChar;
            var path = Path.GetFullPath($"Domain{separate}Context{separate}Seeds{separate}knowledge.json");
            SeedTable<Knowledge>(path, modelBuilder);
        }

        protected void SeedTable<T>(string jsonPath, ModelBuilder modelBuilder) where T : EntityBase
        {
            var json = new StreamReader(jsonPath, Encoding.UTF8).ReadToEnd();
            var seeds = JsonConvert.DeserializeObject<IEnumerable<T>>(json);
            var date = new DateTime(2021, 01, 09);

            foreach(var seed in seeds)
            {
                seed.Id = Guid.NewGuid();
                seed.DateAdded = date;
                seed.DateModified = date;
            }

            SeedTable(seeds, modelBuilder);
        }

        protected void SeedTable<T>(IEnumerable<T> seeds, ModelBuilder modelBuilder) where T : class
        {
            modelBuilder.Entity<T>().HasData(seeds);
        }

        public DbSet<Knowledge> Knowledges { get; set; }
    }
}
