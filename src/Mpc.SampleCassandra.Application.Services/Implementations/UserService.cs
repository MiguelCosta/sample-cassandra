namespace Mpc.SampleCassandra.Application.Services.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.JsonPatch;
    using Mpc.SampleCassandra.Application.Dto;
    using Mpc.SampleCassandra.Application.Services.Interfaces;
    using Mpc.SampleCassandra.Domain.Core;

    public class UserService : IUserService
    {
        public UserService(IUnitOfWork unitOfWork)
        {
        }

        public Task<UserDto> CreateAsync(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(JsonPatchDocument<UserDto> user)
        {
            throw new NotImplementedException();
        }
    }
}
