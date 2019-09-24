using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StorefrontApi.DataTransfer;

namespace StorefrontApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeveloperController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> SearchDevelopers([FromQuery] string searchTerm, [FromQuery] string userNameSearchTerm, [FromQuery] string emailSearchTerm, [FromQuery] string displayNameSearchTerm)
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetDeveloper([FromQuery] string developerId)
        {
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateDeveloper(DeveloperDTO developer)
        {
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateDeveloper(DeveloperDTO developer)
        {
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeactivateDeveloper(string developerId)
        {
            return Ok();
        }
    }
}
