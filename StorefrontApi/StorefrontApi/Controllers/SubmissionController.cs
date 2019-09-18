using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorefrontApi.DataTransfer;
using StorefrontApi.LogicalModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StorefrontApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubmissionController : Controller
    {
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> SearchSubmissions(SubmissionSearchParameters searchParameters)
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetSubmission(string gameId)
        {
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateSubmission(Game game, List<IFormFile> gameFiles)
        {
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateSubmission(Game game, List<IFormFile> gameFiles)
        {
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> AddApproval(string submissionId)
        {
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> AddDenial(string submissionId)
        {
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> ReleaseSubmission(bool approved)
        {
            return Ok();
        }
    }
}