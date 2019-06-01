using System;
using System.Threading.Tasks;

namespace TaskManager.Business
{
    public class TaskManagerBusiness : ITaskManagerBusiness
    {
        public async Task<string> GetAllTasks()
        {
            return await Task.FromResult("Get all Tasks new");
        }
    }
}
