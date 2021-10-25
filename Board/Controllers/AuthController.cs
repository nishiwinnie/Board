using System;
using System.Collections.Generic;
using System.Linq;
using Board.Data;
using Board.DTO;
using Board.Entity;
using Board.Interface;
using Board.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Board.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        public AuthController(IUserRepository repository,ITokenService TokenService){
            Repository = repository;
            this.TokenService = TokenService;
        }

        public IUserRepository Repository { get; }
        public ITokenService TokenService { get; }
        
        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult login(User obj){
            var flag = Repository.FindByUserName(obj.UserName); 
            if(flag == null){
                return Unauthorized("Invalid User Name");
            }
            if(flag.Password!=obj.Password){
                return Unauthorized("Invalid Password");
            }
            return Ok(TokenService.createToken(flag));
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public ActionResult<string> registration(UserRegistration obj){
            var flag = Repository.FindByUserName(obj.UserName); 
            if(flag != null){
                return Unauthorized("User Already exist");
            }
            User obj1 = new User();
            obj1.UserName = obj.UserName;
            obj1.Password = obj.Password;
            obj1.Name = obj.Name;
            obj1.CreatedBy = obj.UserName;
            obj1.LastUpdatedBy = obj.UserName;
            obj1.CreatedDate = DateTime.Now;
            obj1.LastUpdatedDate = DateTime.Now;
            obj1.Access = "1";
            Repository.AddUser(obj1);    
            return "User Added";
        }
        [AllowAnonymous]
        [HttpGet("getUser")]    
        public IEnumerable<User> getDetails(){            
            return Repository.GetAllUsers();
        }
    }
}