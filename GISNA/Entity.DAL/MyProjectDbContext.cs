using Microsoft.EntityFrameworkCore;

namespace GISNA.DAL
{
    public class MyProjectDbContext:DbContext
    {
        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options) : base(options) { }
        public DbSet<Students> Students { get; set; }
    }
}