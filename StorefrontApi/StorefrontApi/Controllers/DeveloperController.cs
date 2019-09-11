using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StorefrontApi.DataTransfer;

namespace StorefrontApi.Controllers
{
    [Route("api/[controller]")]
    public class DeveloperController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> SearchDevelopers(DeveloperSearchParameters searchParameters)
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetDeveloper(string developerId)
        {
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> CreateDeveloper(DeveloperDTO developer)
        {
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> UpdateDeveloper(DeveloperDTO developer)
        {
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> DeactivateDeveloper(string developerId)
        {
            return Ok();
        }
    }
}
