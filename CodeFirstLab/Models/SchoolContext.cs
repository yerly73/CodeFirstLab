using Microsoft.EntityFrameworkCore;

namespace CodeFirstLab.Models
{
    public class SchoolContext : DbContext
    {
        //clases
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1504-11\\SQLEXPRESS;Initial Catalog=AysaDB;User Id=yerly;Password=123456;Trusted_Connection=True;TrustServerCertificate=True");
            
        }
    }
}
