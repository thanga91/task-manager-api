using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Business
{
    public interface ITaskManagerBusiness
    {
        Task<string> GetAllTasks();
    }
}
