using System;
using System.Threading.Tasks;

namespace TaskManager.Repository
{
    public class TaskManagerRepository : ITaskManagerRepository
    {
        public async Task<string> GetAllTasks()
        {
            return await Task.FromResult("GetAllTask From repos");
        }
    }
}
