using SuperCom.Services.Models;

namespace SuperCom.Services.Interfaces
{
    internal interface ISuperComTaskService
    {
        IEnumerable<SuperComTask> GetQueueTasks();
    }
}
