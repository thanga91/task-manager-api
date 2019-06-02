using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Business;
using TaskManager.Core;

namespace TaskManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManagerController : ControllerBase
    {
        private readonly ITaskManagerBusiness _taskManagerBusiness;
        public TaskManagerController(ITaskManagerBusiness taskManagerBusiness)
        {
            _taskManagerBusiness = taskManagerBusiness;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllTasks()
        {
            var tasks = await _taskManagerBusiness.GetAllTasks();
            return Ok(tasks);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var task = await _taskManagerBusiness.GetTask(id);
            return Ok(task);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddTask(TaskViewModel taskViewModel)
        {

            await _taskManagerBusiness.AddTask(taskViewModel);
            return Ok("Task Added");
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdateTask(TaskViewModel taskViewModel)
        {
            await _taskManagerBusiness.UpdateTask(taskViewModel);
            return Ok("Task updated");
        }

        [HttpDelete("")]

        public async Task<IActionResult> DeleteTask(int id)
        {
            await _taskManagerBusiness.DeleteTask(id);
            return Ok("Deleted Task");
        }
    }
}