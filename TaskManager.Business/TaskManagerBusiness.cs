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
            var taskEntities = await _taskManagerRepository.GetAll();
            var tasks = new List<TaskViewModel>();
            foreach(var taskEntity in taskEntities)
            {
                tasks.Add(new TaskViewModel()
                {
                    Id = taskEntity.Id,
                    TaskName = taskEntity.TaskName,
                    ParentId = taskEntity.ParentId,
                    Priority = taskEntity.Priority,
                    StartDate = taskEntity.StartDate,
                    EndDate = taskEntity.EndDate
                });
            }
            
            return await Task.FromResult(tasks);
        }


        public async Task<TaskViewModel> GetTask(int id)
        {
            var taskEntity = await _taskManagerRepository.Get(id);

            var taskViewModel = new TaskViewModel()
            {
                TaskName = taskEntity.TaskName,
                ParentId = taskEntity.ParentId,
                Priority = taskEntity.Priority,
                StartDate = taskEntity.StartDate,
                EndDate = taskEntity.EndDate,
            };

            return taskViewModel;
        }


        public async Task AddTask(TaskViewModel taskDetails)
        {
            var taskEntity = new TaskDetails()
            {
                TaskName = taskDetails.TaskName,
                ParentId = taskDetails.ParentId,
                Priority = taskDetails.Priority,
                StartDate = taskDetails.StartDate,
                EndDate = taskDetails.EndDate,

            };

            await _taskManagerRepository.Add(taskEntity);
        }

        public async Task UpdateTask(TaskViewModel taskDetails)
        {
            var taskEntity = new TaskDetails()
            {
                TaskName = taskDetails.TaskName,
                ParentId = taskDetails.ParentId,
                Priority = taskDetails.Priority,
                StartDate = taskDetails.StartDate,
                EndDate = taskDetails.EndDate,

            };
            var taskToBeUpdated = await _taskManagerRepository.Get(taskDetails.Id);
            if(taskToBeUpdated != null)
            {
                await _taskManagerRepository.Update(taskToBeUpdated, taskEntity);
            }            
        }

        public async Task DeleteTask(int id)
        {
            var taskEntity = await _taskManagerRepository.Get(id);
            if (taskEntity != null)
            {
                await _taskManagerRepository.Delete(taskEntity);
            }
        }
    }
}
