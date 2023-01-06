using System.ComponentModel.DataAnnotations.Schema;

namespace Education_platform.Models
{
    public class StudentCourse
    {
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Department")]
        public int DepratmentId { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Department Department { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}
