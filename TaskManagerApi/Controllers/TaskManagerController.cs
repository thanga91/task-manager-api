using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManagerController : ControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> GetAllTasks()
        {
            return Ok("Get All Tasks");
        }

        [HttpPost("")]
        public async Task<IActionResult> AddTask()
        {
            return Ok("Task Added");
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdateTask()
        {
            return Ok("Task updated");
        }

        [HttpDelete("")]

        public async Task<IActionResult> DeleteTask()
        {
            return Ok("Deleted Task");
        }
    }
}