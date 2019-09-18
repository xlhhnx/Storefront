using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StorefrontApi.DataTransfer;

namespace StorefrontApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> SearchCompanies([FromQuery] string searchTerm, [FromQuery] string companyName, [FromQuery] string gameTitle)
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetCompany([FromQuery] string comapnyId)
        {
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> CreateCompany(CompanyDTO company)
        {
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> UpdateCompany(CompanyDTO company)
        {
            return Ok();
        }
    }
}