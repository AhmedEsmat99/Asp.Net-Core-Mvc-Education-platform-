using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Education_platform.Models
{
    public class ResultStudent
    {
        [ForeignKey("Courses")]
        public int IdCourse { get; set; }
        [ForeignKey("Student")]
        public int IdStudent { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        [ForeignKey("Department")]
        public int DpartmentId { get; set; }
		[Required]
        [Range(1,3)]
        public int Degree { get; set; }
        public virtual Courses Courses { get; set; }
        public virtual Department Department { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual Student Student { get; set; }

    }
}
