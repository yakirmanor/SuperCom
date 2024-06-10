using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SuperCom.Services.EventHandlers;
using SuperCom.Services.Interfaces;
using SuperCom.Services.QueueMgmt;
using SuperCom.Services.Repository;
using SuperCom.Services.Tasks;

namespace SuperCom.Services.RabbitMq
{
    public static class RabbitMqServiceExtensions
    {
        public static IServiceCollection AddRabbitMqServices(this IServiceCollection services,
            IConfiguration config)
        {
            //Event Bus
            services.AddScoped<IEventBus, RabbitMqSuperComClient>();

            //services.AddSingleton<IEventBus, RabbitMqSuperComClient>(sp =>
            //{
            //    var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
            //    return new RabbitMqSuperComClient(sp.GetService<IMediator>(), scopeFactory);
            //});

            //Subscriptions
            //services.AddTransient<SuperComTaskEventHandler>();

            //Domain Events
            //services.AddTransient<IEventHandler<SuperComTaskCreatedEvent>, SuperComTaskEventHandler>();

            //Application Services
            //services.AddTransient<ISuperComTaskService, ISuperComTaskService>();

            //Data
            //services.AddTransient<ISuperComTaskRepository, SuperComTaskRepository>();
            //services.AddTransient<SuperComTaskDbContext>();

            return services;
        }
    }
}
