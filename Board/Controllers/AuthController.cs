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
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        public AuthController(IUserRepository context,ITokenService TokenService){
            Context = context;
            this.TokenService = TokenService;
        }

        public IUserRepository Context { get; }
        public ITokenService TokenService { get; }
        
        [AllowAnonymous]
        [HttpPost("login")]
        public ActionResult<string> login(UserRegistration obj){
            var flag = Context.FindByUserName(obj.UserName); 
            if(flag == null){
                return Unauthorized("Invalid User Name");
            }
            if(flag.Password!=obj.Password){
                return Unauthorized("Invalid Password");
            }
            return TokenService.createToken(flag);
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public ActionResult<string> registration(UserRegistration obj){
            var flag = Context.FindByUserName(obj.UserName); 
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
            Context.AddUser(obj1);    
            return "User Added";
        }
        [Authorize]
        [HttpGet("getUser")]    
        public IEnumerable<User> getDetails(){            
            return Context.GetAllUsers();
        }
    }
}