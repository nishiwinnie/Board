using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.Interface;
using Board.Entity;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        public TaskController(ITaskRepository taskRepository){
            TaskRepository = taskRepository;
        }

        public ITaskRepository TaskRepository { get; }

        [AllowAnonymous]
        [HttpPost("addTask")]      
        public IActionResult AddStatus(Task obj){
            var flag = TaskRepository.AddTask(obj);
            if (flag!=null)
            {
            return Ok(flag);
            }
            else
            {
                return Ok(null);
            }
        }
        [AllowAnonymous]
        [HttpGet("getTask")]
        public IActionResult GetTask()
        {
            var result = TaskRepository.GetAllTask();
            return Ok(JsonConvert.SerializeObject(result));
        }

        [AllowAnonymous]
        [HttpPut("updateTask")]
        public IActionResult updateTask(Task obj)
        {
            var result = TaskRepository.UpdateTask(obj);
            return Ok(result);
        }
    }
}