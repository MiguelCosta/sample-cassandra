namespace Mpc.SampleCassandra.Domain.Core
{
    using System;
    using System.Threading.Tasks;

    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }

        Task CompleteAsync();
    }
}
