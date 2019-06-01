using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Repository
{
    public interface ITaskManagerRepository
    {
        Task<string> GetAllTasks();
    }
}
