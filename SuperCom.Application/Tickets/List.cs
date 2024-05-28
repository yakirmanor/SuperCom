using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SuperCom.Application.Core;
using SuperCom.Domain;
using SuperCom.Persistence;

namespace SuperCom.Application.Tickets
{
    public class List
    {
        public class Query : IRequest<Result<List<Ticket>>> { }

        public class Handler : IRequestHandler<Query, Result<List<Ticket>>>
        {
            private readonly DataContext _context;
            private readonly ILogger<List> _logger;

            public Handler(DataContext context, ILogger<List> logger)
            {
                _logger = logger;
                _context = context;
            }

            public async Task<Result<List<Ticket>>> Handle(Query request, CancellationToken cancellationToken)
            {
                /*
                // this code if for later to show multi delayed response
                try
                {
                    for (int i = 0; i < 100; i++)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        await Task.Delay(1000, cancellationToken);
                        _logger.LogInformation($"Task {i} has completed", i);
                    }
                }
                catch (System.Exception)
                {
                    _logger.LogInformation("Task was cancelled");
                }
                */
                
                return Result<List<Ticket>>.Success(await _context.Tickets.ToListAsync());
            }
        }
    }
}

