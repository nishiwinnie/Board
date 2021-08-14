using System.Collections.Generic;
using Board.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SprintController : ControllerBase
    {
        public SprintController(ISprintRepository sprintRepository){
            SprintRepository = sprintRepository;
        }
        public ISprintRepository SprintRepository { get; }

        [HttpGet("getAllSprint")]    
        public IEnumerable<Sprint> getAllSprint(){            
            return SprintRepository.GetAllSprint();
        }
        
        [Authorize]
        [HttpPost("addSprint")]
        public ActionResult<string> addSprint(Sprint obj){
            var flag = SprintRepository.FindById(obj.id); 
            if(flag != null){
                return Unauthorized("Sprint Already exist");
            }
            SprintRepository.AddSprint(obj);    
            return "Sprint Added";
        }
    }
}