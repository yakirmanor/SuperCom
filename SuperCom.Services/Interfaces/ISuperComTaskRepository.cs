using SuperCom.Services.Models;

namespace SuperCom.Services.Interfaces
{
    public interface ISuperComTaskRepository
    {
        IEnumerable<SuperComTask> GetSuperComTasks();
        void Add(SuperComTask queueTask);
    }
}
