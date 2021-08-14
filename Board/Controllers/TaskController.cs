using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.Interface;

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

        [HttpPost("addstatus")]
        public ActionResult<string> AddStatus(TaskRepository obj){
            
            return "Status Added";
        }
    }
}