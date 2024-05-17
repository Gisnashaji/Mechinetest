using Microsoft.EntityFrameworkCore;

namespace Web.Student
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext>options):base(options)
        { }
       public DbSet<Student> Students { get; set; } = null;
    }
    
}
