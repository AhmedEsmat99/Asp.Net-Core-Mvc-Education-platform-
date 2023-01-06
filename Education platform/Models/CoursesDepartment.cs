using System.ComponentModel.DataAnnotations.Schema;

namespace Education_platform.Models
{
    public class CoursesDepartment
    {
        [ForeignKey("Department")]
        public int DeaprtmentId { get; set; }
        [ForeignKey("Courses")]
        public int CoursesId { get; set; }
        public virtual Department Department { get; set; }
        public virtual Courses Courses { get; set; }
    }
}
