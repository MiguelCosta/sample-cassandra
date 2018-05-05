namespace Mpc.SampleCassandra.Application.Services.Adapters
{
    using System.Collections.Generic;
    using System.Linq;
    using Mpc.SampleCassandra.Domain.Models;

    public static class UserAdapter
    {
        public static UserModel ToDomain(this Dto.User user)
        {
            return user == null ? null : new UserModel
            {
                BirthDay = user.BirthDay,
                Name = user.Name,
                Username = user.Username
            };
        }

        public static Dto.User ToDto(this UserModel user)
        {
            return user == null ? null : new Dto.User
            {
                BirthDay = user.BirthDay,
                Name = user.Name,
                Username = user.Username
            };
        }

        public static IEnumerable<Dto.User> ToDto(this IEnumerable<UserModel> users)
        {
            return users?.Select(ToDto);
        }
    }
}
