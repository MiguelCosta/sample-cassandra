namespace Mpc.SampleCassandra.Data.Repository.Cassandra
{
    using System.Threading.Tasks;
    using Mpc.SampleCassandra.Domain.Core;

    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IUserRepository userRepository)
        {
            this.Users = userRepository;
        }

        public IUserRepository Users { get; };

        public Task CompleteAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
