using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Recruitment.API.Infrastructure;
using Recruitment.API.Utility;
using Recruitment.Contracts;
using System.Threading.Tasks;

namespace Recruitment.API.Controllers
{
    public class IdentityApiController : BaseApiController
    {
        public IdentityApiController(IAppInjector appInjector) : base(appInjector)
        {
        }

        [HttpPost("hash")]
        public async Task<IActionResult> Login([FromBody] LoginRequestCommand model)
        {
            try
            {
                var result = await _mediator.Send(model);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex.Message.ToString());
                return BadRequest("something went wrong");
            }

        }
    }
}
