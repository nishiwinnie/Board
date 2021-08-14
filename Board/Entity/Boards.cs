using System;

namespace Board.Entity
{
    public class Boards
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}