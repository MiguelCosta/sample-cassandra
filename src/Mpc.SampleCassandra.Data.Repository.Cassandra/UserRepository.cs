namespace Mpc.SampleCassandra.Data.RepositoryCassandra
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Cassandra;
    using Cassandra.Data.Linq;
    using Mpc.SampleCassandra.Domain.Core;
    using Mpc.SampleCassandra.Domain.Models;

    public class UserRepository : IUserRepository
    {
        private Table<UserModel> query;
        private ISession session;

        public UserRepository(ISession session)
        {
            this.session = session;
            this.query = new Table<UserModel>(session);
        }

        public async Task<UserModel> AddAsync(UserModel user)
        {
            var newUser = await this.query
                .Insert(user)
                .IfNotExists()
                .ExecuteAsync()
                .ConfigureAwait(false);

            return user;
        }

        public void Delete(string username)
        {
            throw new System.NotImplementedException();
        }

        public async Task<UserModel> FindAsync(string username)
        {
            var user = await this.query
                .Where(x => x.Username == username)
                .FirstOrDefault()
                .ExecuteAsync()
                .ConfigureAwait(false);

            return user;
        }

        public async Task<List<UserModel>> GetAllAsync()
        {
            var users = await this.query
                .ExecuteAsync()
                .ConfigureAwait(false);

            return users.ToList();
        }

        public void Update(UserModel user)
        {
            throw new System.NotImplementedException();
        }
    }
}
