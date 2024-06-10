using SuperCom.Services.Interfaces;
using SuperCom.Services.Models;

namespace SuperCom.Services.Repository
{
    public class SuperComTaskRepository : ISuperComTaskRepository
    {
        private SuperComTaskDbContext _context;

        public SuperComTaskRepository(SuperComTaskDbContext context)
        {
            _context = context;
        }

        public void Add(SuperComTask transferLog)
        {
            _context.SuperComTasks.Add(transferLog);
            _context.SaveChanges();
        }

        public IEnumerable<SuperComTask> GetSuperComTasks()
        {
            return _context.SuperComTasks;
        }
    }
}
