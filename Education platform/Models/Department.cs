using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Education_platform.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        public string NameManger { get; set; }
        [Required]
        public string image { get; set; }
        [Required]
        public string Description { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<CoursesDepartment> CoursesDepartments { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses  { get; set; }
        public virtual ICollection<ResultStudent> ResultStudents { get; set; }
    }
}
