using Board.Entity;

using Microsoft.EntityFrameworkCore;

namespace Board.Data
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions options) :base(options){}
        public DbSet<User> Users{ get; set; }
        public DbSet<Boards> Boards{ get; set; }
        public DbSet<Comments> Comments{ get; set; }
        public DbSet<Sprint> Sprint{ get; set; }
        public DbSet<Status> Status{ get; set; }
        public DbSet<TaskType> TaskType{ get; set; }
        public DbSet<Task> Task{ get; set; }

    }
}