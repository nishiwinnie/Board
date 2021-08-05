using System;
using System.ComponentModel.DataAnnotations;

namespace Board.Entity
{
    public class User
    {
        public int id { get; set; }
        [Required] public string UserName { get; set; }
        [Required] public string Password { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        
    }
}