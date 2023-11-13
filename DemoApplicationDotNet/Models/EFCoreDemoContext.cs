using Microsoft.EntityFrameworkCore;

namespace DemoApplication.Models
{
    public class EFCoreDemoContext : DbContext
    {
        public EFCoreDemoContext(DbContextOptions<EFCoreDemoContext> options) 
            :base(options) 
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
