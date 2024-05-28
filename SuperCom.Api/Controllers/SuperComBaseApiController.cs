using MediatR;
using Microsoft.AspNetCore.Mvc;
using SuperCom.Application.Core;

namespace SuperCom.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuperComBaseApiController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= 
            HttpContext.RequestServices.GetService<IMediator>();

        protected ActionResult HandleResult<T>(Result<T> result)
        {
            if (result == null) return NotFound();

            if (result.IsSuccess && result.Value != null)
                return Ok(result.Value);

            if (result.IsSuccess && result.Value == null)
                return NotFound();

            return BadRequest(result.Error);
        }
    }
}