using Microsoft.AspNetCore.Mvc;
using StorefrontApi.DataTransfer;
using System.Threading.Tasks;

namespace StorefrontApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetCart(string userId)
        {
            return Ok();
        }

        [HttpPost]
        [Route("[action")]
        public async Task<IActionResult> AddGame(string gameId)
        {
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> RemoveGame(string gameId)
        {
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> MakePayment(string userId, PaymentInfoDTO paymentInfo)
        {
            return Ok();
        }
    }
}
