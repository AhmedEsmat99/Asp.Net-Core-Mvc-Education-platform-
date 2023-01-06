using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Education_platform.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        [Range(15, 35)]
        [StringLength(2)]
        public int Age { get; set; }
        [StringLength(11)]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [StringLength(50)]
        public string Adress { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [ForeignKey("Department")]
        public int IdDept { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<InstructorCourses> InstructorCourses { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses  { get; set; }
        public virtual ICollection<ResultStudent> ResultStudents { get; set; }
    }
}
