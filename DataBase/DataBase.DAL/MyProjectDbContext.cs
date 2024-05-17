using Microsoft.EntityFrameworkCore;

namespace DataBase.DAL
{
    public class MyProjectDbContext : DbContext
    {
        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options) : base(options) { }
        public DbSet<Students> Students { get; set; }
        public object Tasks { get; set; }
    }

    
}