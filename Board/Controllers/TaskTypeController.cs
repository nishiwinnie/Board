using System.Collections.Generic;
using Board.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskTypeController : ControllerBase
    {
        public TaskTypeController(ITaskTypeRepository taskTypeRepository){
            TaskTypeRepository = taskTypeRepository;
        }
        public ITaskTypeRepository TaskTypeRepository { get; }

        [HttpGet("getAllTaskType")]    
        public IEnumerable<TaskType> getAllTaskType(){            
            return TaskTypeRepository.GetAllTaskType();
        }
        
        [Authorize]
        [HttpPost("addTaskType")]
        public ActionResult<string> addTaskType(TaskType obj){
            var flag = TaskTypeRepository.FindByName(obj.Name); 
            if(flag != null){
                return Unauthorized("TaskType Already exist");
            }
            TaskTypeRepository.AddTaskType(obj);    
            return "TaskType Added";
        }
        
    }
}