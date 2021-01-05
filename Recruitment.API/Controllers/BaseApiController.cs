using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Recruitment.API.Infrastructure;
using Recruitment.API.Utility;
using System;
using System.Threading.Tasks;

namespace Recruitment.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected readonly IMediator _mediator;
        protected readonly ILogger _logger;
        public BaseApiController(IAppInjector injector)
        {
            _mediator = injector.Mediator;
            _logger = injector.Logger;
        }

    }
}
