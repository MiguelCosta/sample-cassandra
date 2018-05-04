namespace Mpc.SampleCassandra.Domain.Core
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.SampleCassandra.Domain.Models;

    public interface IUserRepository
    {
        UserModel Add(UserModel user);

        void Delete(string username);

        Task<UserModel> FindAsync(string username);

        Task<List<UserModel>> GetAllAsync();

        void Update(UserModel user);
    }
}
