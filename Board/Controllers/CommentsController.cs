using System;
using System.Collections.Generic;
using Board.Entity;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentsController : ControllerBase
    {
        public CommentsController(ICommentsRepository commentsRepository){
            CommentsRepository = commentsRepository;
        }

        public ICommentsRepository CommentsRepository { get; }

        [HttpGet("getAllComments")]    
        public IEnumerable<Comments> getAllComments(){            
            return CommentsRepository.GetAllComments();
        }
        
        [Authorize]
        [HttpPost("addComments")]
        public ActionResult<string> addComments(CommentsDTO obj){
            var flag = CommentsRepository.FindById(obj.TaskId); 
            if(flag != null){
                return Unauthorized("Comments Already exist");
            }
            Comments obj1 = new Comments();
            obj1.TaskId=obj.TaskId;
            obj1.Value=obj.Value;
            obj1.CreatedDate = DateTime.Now;
            obj1.CreatedBy = 1;
            CommentsRepository.AddComments(obj1);    
            return "Comments Added";
        }
    }
}