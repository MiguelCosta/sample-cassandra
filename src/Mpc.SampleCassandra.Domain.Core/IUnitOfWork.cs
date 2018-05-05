namespace Mpc.SampleCassandra.Domain.Core
{
    using System;
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
        IUserRepository Users { get; }

        Task CompleteAsync();
    }
}
