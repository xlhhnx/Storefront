using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StorefrontApi.DataTransfer;

namespace StorefrontApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> SearchUsers([FromQuery] string searchTerm, [FromQuery] string userNameSearchTerm, [FromQuery] string emailSearchTerm, [FromQuery] string displayNameSearchTerm)
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetUser([FromQuery] string userId)
        {
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateUser(UserDTO user)
        {
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateUser(UserDTO user)
        {
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeactivateUser(string userId)
        {
            return Ok();
        }
    }
}