namespace Mpc.SampleCassandra.Data.Repository.Cassandra
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.SampleCassandra.Domain.Core;
    using Mpc.SampleCassandra.Domain.Models;

    public class UserRepository : IUserRepository
    {
        public UserModel Add(UserModel user)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string username)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserModel> FindAsync(string username)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<UserModel>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Update(UserModel user)
        {
            throw new System.NotImplementedException();
        }
    }
}
