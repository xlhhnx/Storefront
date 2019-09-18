using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorefrontApi.DataTransfer;

namespace StorefrontApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> SearchGames(GameSearchParameters searchParameters)
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetGame([FromQuery] string Id)
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> DownloadGame([FromQuery] string Id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateGame(GameDTO game, List<IFormFile> storePageFiles, List<IFormFile> gameFiles)
        {
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateGame(GameDTO game)
        {
            return Ok();
        }
    }
}