using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StorefrontApi.DataTransfer;

namespace StorefrontApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> SearchUsers([FromBody] UserSearchParameters searchParameters)
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetUser([FromBody] string userId)
        {
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> CreateUser([FromBody] UserDTO user)
        {
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> UpdateUser([FromBody] UserDTO user)
        {
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> DeactivateUser([FromBody] string userId)
        {
            return Ok();
        }
    }
}