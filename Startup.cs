using ApiResume.Domain.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ApiResume.Domain.Utils;
using ApiResume.Services;
using ApiResume.Services.Interfaces;
using ApiResume.Domain.Repository.Interfaces;
using ApiResume.Domain.Repository;

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
        }

        private void ConfigureDI(IServiceCollection services)
        {
            services.AddScoped<IKnowledgeRepository, KnowledgeRepository>();
            services.AddScoped<IKnowledgeService, KnowledgeService>();
            services.AddSingleton(ConfigMapper.Configure());
        }
    }
}
