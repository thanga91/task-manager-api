using System;
using System.Collections;
using System.Threading.Tasks;
using TaskManager.Repository;
using TaskManager.Repository.Context;
using TaskManager.Core;
using System.Collections.Generic;

namespace TaskManager.Business
{
    public class TaskManagerBusiness : ITaskManagerBusiness
    {
        private readonly ITaskManagerRepository<TaskDetails> _taskManagerRepository;
        public TaskManagerBusiness(ITaskManagerRepository<TaskDetails> taskManagerRepository)
        {
            _taskManagerRepository = taskManagerRepository;
        }
        public async Task<IEnumerable<TaskViewModel>> GetAllTasks()
        {
            var taskEntities = await _taskManagerRepository.GetAllTasks();
            var tasks = new List<TaskViewModel>();
            foreach(var taskEnity in taskEntities)
            {
                tasks.Add(new TaskViewModel()
                {
                    Id = taskEnity.Id,
                    TaskName = taskEnity.TaskName
                    
                });
            }
            
            return await Task.FromResult(tasks);
        }

    }
}
