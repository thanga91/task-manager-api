using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManager.Repository.Context;

namespace TaskManager.Repository
{
    public class TaskManagerRepository : ITaskManagerRepository<TaskDetails>
    {
        public async Task<IEnumerable<TaskDetails>> GetAllTasks()
        {
            return await Task.FromResult(new List<TaskDetails>());
        }
    }
}
