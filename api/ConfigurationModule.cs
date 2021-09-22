using Autofac;
using Autofac.Features.AttributeFilters;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace api
{
    public class ConfigurationModule : Module
    {
        private readonly IConfiguration _configuration;

        public ConfigurationModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(j => j.Name.EndsWith("Repository") || j.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerDependency()
                .WithAttributeFiltering();

            builder.Register<IDbConnection>(ctx => new SqlConnection(_configuration.GetSection("ConnectionString:APIConnection").Value));
        }
    }
}
