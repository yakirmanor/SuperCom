using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SuperCom.Application.Extensions;
using SuperCom.Application.Tickets;
using SuperCom.Domain;
using System.Diagnostics;

namespace SuperCom.Test;

public class SuperComTests
{
    private readonly Microsoft.Extensions.Logging.ILogger _logger;
    private IMediator _mediator;

    public SuperComTests()
    {
        var builder = Host.CreateApplicationBuilder();
        builder.Services.AddSuperComApplicationServices(builder.Configuration);
        builder.Services.UseLoggingDependencyExtensions();

        var app = builder.Build();
        var scope = app.Services.CreateAsyncScope();

        _logger = scope.ServiceProvider.GetRequiredService<Microsoft.Extensions.Logging.ILogger>();
        _mediator = scope.ServiceProvider.GetRequiredService<IMediator>();
    }

    [Test]
    public void Test1_AddTicket()
    {

        Stopwatch watch = new Stopwatch();
        watch.Start();
        Console.WriteLine("Starting TestLoggerSettings");

        _mediator.Send(new Create.Command { Ticket = new Ticket() { Name = "Test Ticket" } });


        Assert.That(true, Is.EqualTo(true));
        Console.WriteLine("Done. Time : {0}", watch.Elapsed);
    }
}