namespace Mpc.SampleCassandra.Application.Services.Configuration
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Mpc.SampleCassandra.Application.Services.Implementations;
    using Mpc.SampleCassandra.Application.Services.Interfaces;

    internal static class DependenciesConfiguration
    {
        internal static void ConfigureDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
