using System;

namespace Board.Entity
{
    public class Comments
    {
        public int id { get; set; }
        public int TaskId { get; set; }
        public string Value { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}