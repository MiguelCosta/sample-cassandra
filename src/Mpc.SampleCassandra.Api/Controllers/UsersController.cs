namespace Mpc.SampleCassandra.Api.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Mpc.SampleCassandra.Application.Dto;
    using Mpc.SampleCassandra.Application.Services.Interfaces;

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        [Produces(typeof(UserDto))]
        public async Task<IActionResult> PostAsync([FromBody]UserDto user)
        {
            var newuser = await this.userService.CreateAsync(user);

            var location = $"{this.Request.PathBase}/{this.Request.Path}/{newuser.Username}";

            return this.Created(location, newuser);
        }
    }
}
