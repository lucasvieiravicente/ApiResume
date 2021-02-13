using ApiResume.Domain.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ApiResume.Services;
using ApiResume.Services.Interfaces;
using ApiResume.Domain.Repository.Interfaces;
using ApiResume.Domain.Repository;
using ApiResume.Domain.BlobContext.Interfaces;
using ApiResume.Domain.BlobContext;
using ApiResume.Domain.Utils;
using Swashbuckle;
using Microsoft.OpenApi.Models;
using System;

namespace ApiResume
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            ConfigureDI(services);
            var connection = Configuration.GetConnectionString("ApiData");
            services.AddDbContext<EFContext>(options => options.UseSqlServer(connection));
            ConfigureSwaggerGenInfos(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            ConfigureSwagger(app);
        }

        private void ConfigureDI(IServiceCollection services)
        {
            services.AddScoped<IKnowledgeRepository, KnowledgeRepository>();
            services.AddScoped<IBlobContext, BlobContext>();
            services.AddScoped<IKnowledgeService, KnowledgeService>();
            services.AddAutoMapper(typeof(ConfigMapper));
        }

        private void ConfigureSwagger(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Knowledge V1");
            });
        }

        private void ConfigureSwaggerGenInfos(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "API Knowledge",
                    Description = "A simple API to populate my webresume online with informations about my carrer and study",
                    License = new OpenApiLicense()
                    {
                        Name = "MIT License",
                        Url = new Uri("https://github.com/lucasvieiravicente/WebResumeAngular/blob/main/LICENSE")
                    },
                    Contact = new OpenApiContact()
                    {
                        Name = "Lucas V. Vicente",
                        Email = "lucasvieiravicente1@gmail.com",
                        Url = new Uri("https://www.linkedin.com/in/lucas-vieira-vicente-885726127/")
                    }
                });
            });
        }
    }
}
