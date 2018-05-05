namespace Mpc.SampleCassandra.Data.RepositoryCassandra
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class Bootstraper
    {
        public static void Init(IServiceCollection services, IConfiguration configuration)
        {
            Mappings.Setup.Map();
            Configuration.DependenciesConfiguration.ConfigureDependencies(services, configuration);
        }
    }
}
