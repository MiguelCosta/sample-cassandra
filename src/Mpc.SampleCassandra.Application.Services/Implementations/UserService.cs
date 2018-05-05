namespace Mpc.SampleCassandra.Application.Services.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.JsonPatch;
    using Mpc.SampleCassandra.Application.Dto;
    using Mpc.SampleCassandra.Application.Services.Adapters;
    using Mpc.SampleCassandra.Application.Services.Interfaces;
    using Mpc.SampleCassandra.Domain.Core;

    public class UserService : IUserService
    {
        private IUnitOfWork unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<User> CreateAsync(User user)
        {
            var newUser = await this.unitOfWork.Users
                .AddAsync(user.ToDomain())
                .ConfigureAwait(false);

            return newUser.ToDto();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> FindAsync(string username)
        {
            var userModel = await this.unitOfWork.Users.FindAsync(username).ConfigureAwait(false);

            return userModel.ToDto();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var users = await this.unitOfWork.Users.GetAllAsync().ConfigureAwait(false);

            return users.ToDto();
        }

        public Task UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(JsonPatchDocument<User> user)
        {
            throw new NotImplementedException();
        }
    }
}
