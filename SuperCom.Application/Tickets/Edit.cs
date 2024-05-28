using MediatR;
using AutoMapper;
using FluentValidation;
using SuperCom.Application.Core;
using SuperCom.Domain;
using SuperCom.Persistence;

namespace SuperCom.Application.Tickets
{
public class Edit
{
    public class Command : IRequest<Result<Unit>>
    {
        public Ticket Ticket { get; set; }
    }

    public class CommandValidator : AbstractValidator<Command>
    {
        public CommandValidator()
        {
            RuleFor(x => x.Ticket).SetValidator(new TicketValidator());
        }
    }

    public class Handler : IRequestHandler<Command, Result<Unit>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public Handler(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
        {
            var activity = await _context.Tickets.FindAsync(request.Ticket.Id);

            if (activity == null) return null;

            _mapper.Map(request.Ticket, activity);

            var result = await _context.SaveChangesAsync() > 0;

            if (!result) return Result<Unit>.Failure("Failed to update activity");

            return Result<Unit>.Success(Unit.Value);
        }
    }
}
}

