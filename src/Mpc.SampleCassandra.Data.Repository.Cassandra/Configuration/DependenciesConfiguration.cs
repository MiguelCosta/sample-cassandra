namespace Mpc.SampleCassandra.Data.RepositoryCassandra.Configuration
{
    using Cassandra;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Mpc.SampleCassandra.Domain.Core;

    internal static class DependenciesConfiguration
    {
        internal static void ConfigureDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ISession>(x => FactorySession(configuration));

            services.AddScoped<IUserRepository, UserRepository>();
        }

        private static ISession FactorySession(IConfiguration configuration)
        {
            var contactPoints = configuration["Cassandra:ContactPoints"];
            var keySpace = configuration["Cassandra:KeySpace"];
            var cluster = Cluster.Builder()
                .AddContactPoint(contactPoints)
                .Build();
            var session = cluster.Connect(keySpace);

            return session;
        }
    }
}
