namespace Mpc.SampleCassandra.Data.RepositoryCassandra.Mappings.Tables
{
    using Cassandra.Mapping;
    using Mpc.SampleCassandra.Domain.Models;

    public class UserMapping : Mappings
    {
        public UserMapping()
        {
            For<UserModel>()
                .TableName("user")
                .PartitionKey("username")
                .Column(u => u.BirthDay, cm => cm.WithName("birthday"))
                .Column(u => u.Name, cm => cm.WithName("name"))
                .Column(u => u.Username, cm => cm.WithName("username"))
                .ExplicitColumns()
                ;
        }
    }
}
