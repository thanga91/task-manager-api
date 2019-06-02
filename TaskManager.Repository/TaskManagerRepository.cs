using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Repository.Context;

namespace TaskManager.Repository
{
    public class TaskManagerRepository : ITaskManagerRepository<TaskDetails>
    {
        private readonly TaskDbContext _taskDbContext;
        public TaskManagerRepository(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }
       
        public async Task<IEnumerable<TaskDetails>> GetAll()
        {
            return await Task.FromResult(_taskDbContext.TaskDetails.ToList());
        }

        public async Task Add(TaskDetails entity)
        {
            _taskDbContext.TaskDetails.Add(entity);
            await _taskDbContext.SaveChangesAsync();
        }

    }
}
