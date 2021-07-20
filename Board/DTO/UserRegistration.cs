using System.ComponentModel.DataAnnotations;

namespace Board.DTO
{
    public class UserRegistration
    {
        [Required] public string UserName { get; set; }
        [Required] public string Password { get; set; }
        [Required] public string Name { get; set; }
    }
}