using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Education_platform.Models
{
    public class InstructorCourses
    {
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        [ForeignKey("Courses")]
        public int CoursesId { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual Courses Courses { get; set; }

    }
}
