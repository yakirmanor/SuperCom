using MediatR;
using SuperCom.Application.Core;
using SuperCom.Domain;
using SuperCom.Persistence;

namespace SuperCom.Application.Tickets
{
    public class Details
    {
        public class Query : IRequest<Result<Ticket>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<Ticket>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Result<Ticket>> Handle(Query request, CancellationToken cancellationToken)
            {
                var ticket = await _context.Tickets.FindAsync(request.Id);

                return Result<Ticket>.Success(ticket);
            }
        }
    }
}