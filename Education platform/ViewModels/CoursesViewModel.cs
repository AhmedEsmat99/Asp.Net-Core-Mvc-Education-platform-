using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Education_platform.ViewModels
{
    public class CoursesViewModel : EditImageViewModel
    {
        [Required]
        public string NameCourses { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Degree { get; set; }
        [Required]
        public int MinDegree { get; set; }
        [Display(Name ="Picture")]
        [DataType(DataType.Upload)]
        public IFormFile Image { get; set; }
    }
}
