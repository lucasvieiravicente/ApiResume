using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;

namespace ApiResume.Domain.Utils
{
    public class ConfigSwagger : IConfigureNamedOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;
        public ConfigSwagger(IApiVersionDescriptionProvider provider) => _provider = provider;

        public void Configure(SwaggerGenOptions options)
        {
            // add swagger document for every API version discovered
            foreach (var description in _provider.ApiVersionDescriptions)
                options.SwaggerDoc(description.GroupName, CreateVersionInfo(description));
        }

        public void Configure(string name, SwaggerGenOptions options)
        {
            Configure(options);
        }

        private OpenApiInfo CreateVersionInfo(ApiVersionDescription description)
        {
            var info = new OpenApiInfo()
            {
                Version = description.ApiVersion.ToString(),
                Title = $"API Knowledge {description.GroupName}",
                Description = "A simple API to populate my webresume online with informations about my professional knowledge and study.",
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
            };

            if (description.IsDeprecated)
                info.Description += " (This API version has been deprecated).";

            return info;
        }
    }
}
