using Microsoft.EntityFrameworkCore;

namespace Seminary.Model
{
    public class SeminaryContext:DbContext
    {
        public SeminaryContext(DbContextOptions<SeminaryContext>options):base(options)
        {

        }

        public DbSet<ClassStudent> ClassStudents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}