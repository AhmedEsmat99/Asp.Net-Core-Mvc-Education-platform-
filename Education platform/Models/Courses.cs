using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Education_platform.Models
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25, ErrorMessage = "Name Cours Must Be Less Than 25 Letter ")]
        [MinLength(2, ErrorMessage = "Name Cours Must Be Greater than 2 Letter")]
        public string Name { get; set; }
        [Required]
        [Range(50, 100)]
        public int Degree { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public int MinDegree {get;set; }
        public virtual ICollection<InstructorCourses> InstructorCourses { get; set; }
        public virtual ICollection<CoursesDepartment> CoursesDepartments { get; set; }
        public virtual ICollection<ResultStudent> ResultStudents { get; set; }
    }
}
