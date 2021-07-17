using Board.Entity;
using Microsoft.EntityFrameworkCore;

namespace Board.Data
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions options) :base(options){}
        public DbSet<User> Users{ get; set; }
    }
}