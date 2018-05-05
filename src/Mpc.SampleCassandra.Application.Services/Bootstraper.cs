namespace Mpc.SampleCassandra.Application.Services
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class Bootstraper
    {
        public static void Init(IServiceCollection services, IConfiguration configuration)
        {
            Configuration.DependenciesConfiguration.ConfigureDependencies(services, configuration);
        }
    }
}
