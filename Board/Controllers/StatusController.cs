using System.Collections.Generic;
using Board.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        public StatusController(IStatusRepository statusRepository){
            StatusRepository = statusRepository;
        }
        public IStatusRepository StatusRepository { get; }

        [HttpGet("getAllStatus")]    
        public IEnumerable<Status> getAllStatus(){            
            return StatusRepository.GetAllStatus();
        }
                
        [Authorize]
        [HttpPost("addStatus")]
        public ActionResult<string> addStatus(Status obj){
            var flag = StatusRepository.FindByName(obj.Name); 
            if(flag != null){
                return Unauthorized("Status Already exist");
            }
            StatusRepository.AddStatus(obj);    
            return "Status Added";
        }
    }
}