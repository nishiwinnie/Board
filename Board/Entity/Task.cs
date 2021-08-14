using System;

namespace Board.Entity
{
    public class Task
    {
        public int id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public int SprintId { get; set; }
        public int AssignedTo { get; set; }
        public int BoardId { get; set; }
        
    }
}