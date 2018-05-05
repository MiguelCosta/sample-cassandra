namespace Mpc.SampleCassandra.Application.Services.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.JsonPatch;
    using Mpc.SampleCassandra.Application.Dto;

    public interface IUserService
    {
        Task<User> CreateAsync(User user);

        Task DeleteAsync(string id);

        Task<User> FindAsync(string username);

        Task<IEnumerable<User>> GetAllAsync();

        Task UpdateAsync(User user);

        Task UpdateAsync(JsonPatchDocument<User> user);
    }
}
