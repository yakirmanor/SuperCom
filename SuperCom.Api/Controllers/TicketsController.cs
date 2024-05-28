using Microsoft.AspNetCore.Mvc;
using SuperCom.Application.Tickets;
using SuperCom.Domain;

namespace SuperCom.Api.Controllers
{
    public class TicketsController : SuperComBaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Ticket>>> GetTickets(CancellationToken ct)
        {
            return HandleResult(await Mediator.Send(new List.Query(), ct));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ticket>> GetTicket(Guid id)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateTicket(Ticket Ticket)
        {
            return HandleResult(await Mediator.Send(new Create.Command { Ticket = Ticket }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, Ticket Ticket)
        {
            Ticket.Id = id;
            return HandleResult(await Mediator.Send(new Edit.Command { Ticket = Ticket }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}