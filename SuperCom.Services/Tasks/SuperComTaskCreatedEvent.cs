using SuperCom.Services.QueueMgmt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCom.Services.Tasks
{
    public class SuperComTaskCreatedEvent : Event
    {
        public Guid Id { get; private set; }
        public string Description { get; private set; }

        public SuperComTaskCreatedEvent(Guid id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
