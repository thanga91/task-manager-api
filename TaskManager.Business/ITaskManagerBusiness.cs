using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core;

namespace TaskManager.Business
{
    public interface ITaskManagerBusiness
    {
        Task<IEnumerable<TaskViewModel>> GetAllTasks();
    }
}
