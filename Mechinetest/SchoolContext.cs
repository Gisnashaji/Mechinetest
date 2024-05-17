using System.Data.Entity;

namespace YourProjectNamespace.Data
{
    using System.Data.Entity;
    using YourProjectNamespace.Models;

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
    }
}


