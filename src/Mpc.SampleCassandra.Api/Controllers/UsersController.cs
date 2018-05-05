namespace Mpc.SampleCassandra.Api.Controllers
{
    using System.Collections.Generic;
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

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<User>), 200)]
        public async Task<IActionResult> GetAsync()
        {
            var users = await this.userService.GetAllAsync().ConfigureAwait(false);

            return this.Ok(users);
        }

        [HttpGet("{username}")]
        [ProducesResponseType(typeof(User), 200)]
        public async Task<IActionResult> GetAsync(string username)
        {
            var user = await this.userService.FindAsync(username).ConfigureAwait(false);

            return this.Ok(user);
        }

        [HttpPost]
        [ProducesResponseType(typeof(User), 201)]
        public async Task<IActionResult> PostAsync([FromBody]User user)
        {
            var newuser = await this.userService.CreateAsync(user).ConfigureAwait(false);

            var location = $"{this.Request.Host}{this.Request.Path}/{newuser.Username}";

            return this.Created(location, newuser);
        }
    }
}
