using System;
using System.Threading.Tasks;
using TaskManager.Repository;

namespace TaskManager.Business
{
    public class TaskManagerBusiness : ITaskManagerBusiness
    {
        private readonly ITaskManagerRepository _taskManagerRepository;
        public TaskManagerBusiness(ITaskManagerRepository taskManagerRepository)
        {
            _taskManagerRepository = taskManagerRepository;
        }
        public async Task<string> GetAllTasks()
        {
            return await _taskManagerRepository.GetAllTasks();
        }
    }
}
