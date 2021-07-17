using System.Linq;
using Board.Data;
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
        public ActionResult<string> login(User obj){
            var flag = Context.FindByUserName(obj.UserName); 
            if(flag == null){
                return Unauthorized("Invalid User Name");
            }
            if(flag.Password!=obj.Password){
                return Unauthorized("Invalid Password");
            }
            return TokenService.createToken(flag);
        }
    }
}