using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Education_platform.Models
{
    public class ProjectDb : IdentityDbContext
    {
        public ProjectDb() : base()
        {

        }
        public ProjectDb(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<InstructorCourses> InstructorCourses { get; set; }
        public DbSet<ResultStudent> ResultStudents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }
        public DbSet<CoursesDepartment> coursesDepartments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= DESKTOP-209KG6L ;Database=EducationPlatform ;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstructorCourses>().HasKey(IC => new { IC.CoursesId, IC.InstructorId });
            modelBuilder.Entity<StudentCourse>().HasKey(SC => new { SC.DepratmentId,SC.InstructorId, SC.StudentId });
            modelBuilder.Entity<CoursesDepartment>().HasKey(CD => new { CD.CoursesId, CD.DeaprtmentId });
            modelBuilder.Entity<ResultStudent>().HasKey(RS => new { RS.IdStudent,RS.IdCourse,RS.InstructorId,RS.DpartmentId});
            base.OnModelCreating(modelBuilder); 
        }
    }
}
