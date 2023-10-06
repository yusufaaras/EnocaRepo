using EnocaNetCoreApi.CQRS.Commands.CarrierCommand;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrierController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarrierController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCarrier([FromBody] CreateCarrierCommand command)
        {
            var carrierId = await _mediator.Send(command);
            return Ok(carrierId);
        }
    }
}
