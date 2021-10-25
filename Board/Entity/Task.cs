using System;

namespace Board.Entity
{
    public class Task
    {
        public int id { get; set; }
        //public int CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public int LastUpdatedBy { get; set; }
        //public DateTime LastUpdatedDate { get; set; }
        //public int SprintId { get; set; }
        //public int BoardId { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string assignedTo { get; set; }
        public string taskName { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string taskDetails { get; set; }

    }
}