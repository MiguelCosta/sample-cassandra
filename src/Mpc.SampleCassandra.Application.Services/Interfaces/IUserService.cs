namespace Mpc.SampleCassandra.Application.Services.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.JsonPatch;
    using Mpc.SampleCassandra.Application.Dto;

    public interface IUserService
    {
        Task<UserDto> CreateAsync(UserDto user);

        Task DeleteAsync(string id);

        Task<IEnumerable<UserDto>> GetAllAsync();

        Task UpdateAsync(UserDto user);

        Task UpdateAsync(JsonPatchDocument<UserDto> user);
    }
}
