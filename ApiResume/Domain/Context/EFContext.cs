using Microsoft.EntityFrameworkCore;
using ApiResume.Domain.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Text;
using ApiResume.Domain.Context.EntityMaps;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace ApiResume.Domain.Context
{
    public class EFContext : DbContext
    {
        private readonly string _pathSeedFiles;
        public static readonly ILoggerFactory loggerFactory = new LoggerFactory(new[] { new DebugLoggerProvider() });

        public EFContext(DbContextOptions<EFContext> options) : base(options) 
        {
            char separatorChar = Path.DirectorySeparatorChar;
            _pathSeedFiles = $"Domain{separatorChar}Context{separatorChar}Seeds{separatorChar}";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(loggerFactory).EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.CreateStackMap();
            modelBuilder.CreateKnowledgeMap();

            SeedTables(modelBuilder);
        }

        protected void SeedTables(ModelBuilder modelBuilder)
        {
            SeedTable<Stack>($"{_pathSeedFiles}stacks.json", modelBuilder);
            SeedTable<Knowledge>($"{_pathSeedFiles}knowledges.json", modelBuilder);
        }

        protected void SeedTable<T>(string jsonPath, ModelBuilder modelBuilder) where T : EntityBase
        {
            var json = new StreamReader(jsonPath, Encoding.UTF8).ReadToEnd();
            var seeds = JsonConvert.DeserializeObject<IEnumerable<T>>(json);
            var date = DateTime.Now;

            foreach(var seed in seeds)
            {
                seed.DateAdded = date;
                seed.DateModified = date;
            }

            modelBuilder.Entity<T>().HasData(seeds);
        }

        public DbSet<Stack> Stacks { get; set; }
        public DbSet<Knowledge> Knowledges { get; set; }
    }
}
