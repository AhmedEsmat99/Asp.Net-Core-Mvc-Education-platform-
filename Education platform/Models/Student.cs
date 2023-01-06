using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Education_platform.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(25)]
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(10,50)]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(11)]
        [Required]
        public string Phone { get; set; }
        public string Image { get; set; }
        [StringLength(50)]
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public virtual ICollection<ResultStudent> ResultStudents { get; set; }
    }
}
