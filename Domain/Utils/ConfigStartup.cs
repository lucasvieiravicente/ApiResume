using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using ApiResume.Domain.BlobContext.Interfaces;
using ApiResume.Domain.Repository;
using ApiResume.Domain.Repository.Interfaces;
using ApiResume.Services;
using ApiResume.Services.Interfaces;
using ApiResume.Domain.Context;
using BlobCont = ApiResume.Domain.BlobContext.BlobContext;

namespace ApiResume.Domain.Utils
{
    public static class ConfigStartup
    {
        public static void ConfigureDatabaseConnection(IConfiguration configuration, IServiceCollection services)
        {
            var connection = configuration.GetConnectionString("ApiData");
            services.AddDbContext<EFContext>(options => options.UseSqlServer(connection));
        }

        public static void ConfigureDI(IServiceCollection services)
        {
            services.AddScoped<IKnowledgeRepository, KnowledgeRepository>();
            services.AddScoped<IBlobContext, BlobCont>();
            services.AddScoped<IKnowledgeService, KnowledgeService>();
            services.AddAutoMapper(typeof(ConfigMapper));
        }

        public static void ConfigureSwagger(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Knowledge V1");
            });
        }

        public static void ConfigureSwaggerGenInfos(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "API Knowledge",
                    Description = "A simple API to populate my webresume online with informations about my professional knowledge and study",
                    License = new OpenApiLicense()
                    {
                        Name = "MIT License",
                        Url = new Uri("https://github.com/lucasvieiravicente/WebResumeAngular/blob/main/LICENSE")
                    },
                    Contact = new OpenApiContact()
                    {
                        Name = "Lucas V. Vicente",
                        Email = "lucasvieiravicente1@gmail.com",
                        Url = new Uri("https://white-moss-0cf7e1e0f.azurestaticapps.net/")
                    }
                });
            });
        }
    }
}
