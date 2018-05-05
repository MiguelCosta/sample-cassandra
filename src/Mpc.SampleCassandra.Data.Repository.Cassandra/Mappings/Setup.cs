namespace Mpc.SampleCassandra.Data.RepositoryCassandra.Mappings
{
    using Cassandra.Mapping;
    using Mpc.SampleCassandra.Data.RepositoryCassandra.Mappings.Tables;

    internal static class Setup
    {
        internal static void Map()
        {
            MappingConfiguration.Global.Define<UserMapping>();
        }
    }
}
