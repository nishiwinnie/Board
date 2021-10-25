using System;

namespace Board.Entity
{
    public class Sprint
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int BoardId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}