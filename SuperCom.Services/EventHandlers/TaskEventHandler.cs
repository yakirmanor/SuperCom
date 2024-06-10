using SuperCom.Services.QueueMgmt;
using SuperCom.Services.Tasks;

namespace SuperCom.Services.EventHandlers
{
    public class SuperComTaskEventHandler : IEventHandler<SuperComTaskCreatedEvent>
    {
        public SuperComTaskEventHandler() {}

        public Task Handle(SuperComTaskCreatedEvent @event)
        {
            // do some handle

            return Task.CompletedTask;
        }
    }
}
