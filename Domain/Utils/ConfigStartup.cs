using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using ApiResume.Domain.BlobContext.Interfaces;
using ApiResume.Domain.Repository;
using ApiResume.Domain.Repository.Interfaces;
using ApiResume.Domain.Context;
using BlobCont = ApiResume.Domain.BlobContext.BlobContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using ApiResume.Services.Interfaces.Knowledges;
using ApiResume.Services.Knowledges;
using ApiResume.Services.Interfaces.Stacks;
using ApiResume.Services.Stacks;

namespace ApiResume.Domain.Utils
{
    public static class ConfigStartup
    {
        public static void ConfigureDatabaseConnection(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("ApiData");
            services.AddDbContext<EFContext>(options => options.UseMySQL(connection));
        }

        public static void ConfigureDI(this IServiceCollection services)
        {
            services.AddScoped<IBlobContext, BlobCont>();
            services.AddScoped<IKnowledgeRepository, KnowledgeRepository>();
            services.AddScoped<IStackRepository, StackRepository>();
            services.AddScoped<IStackService, StackService>();
            services.AddScoped<IKnowledgeServiceV1, KnowledgeServiceV1>();
            services.AddScoped<IKnowledgeServiceV2, KnowledgeServiceV2>();
            services.AddAutoMapper(typeof(ConfigMapper));
        }

        public static void ConfigureApiVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(x =>
            {
                x.DefaultApiVersion = new ApiVersion(2, 0);
                x.AssumeDefaultVersionWhenUnspecified = true;
                x.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(x =>
            {
                x.GroupNameFormat = "'V'V";
                x.SubstituteApiVersionInUrl = true;
            });
        }

        public static void ConfigureSwagger(this IApplicationBuilder app, IApiVersionDescriptionProvider versionProvider)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                foreach(var version in versionProvider.ApiVersionDescriptions)
                    c.SwaggerEndpoint($"/swagger/{version.GroupName}/swagger.json", $"API Knowledge {version.GroupName}");      
            });
        }

        public static void ConfigureSwaggerGenInfos(this IServiceCollection services)
        {
            services.AddSwaggerGen();
            services.ConfigureOptions<ConfigSwagger>();
        }
    }
}
