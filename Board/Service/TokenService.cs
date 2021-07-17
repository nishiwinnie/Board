using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Board.Entity;
using Board.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Board.Service
{
    public class TokenService : ITokenService
    {
        public TokenService(IConfiguration Config) {
            Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Config["TokenKey"]));
        }

        public SymmetricSecurityKey Key { get; }

        public string createToken(User User){
            var Claims = new List<Claim>{
                new Claim(JwtRegisteredClaimNames.NameId, User.UserName)
            };

            var creds = new SigningCredentials(Key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor{
                Subject = new ClaimsIdentity(Claims),
                Expires = System.DateTime.Now.AddDays(7),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}