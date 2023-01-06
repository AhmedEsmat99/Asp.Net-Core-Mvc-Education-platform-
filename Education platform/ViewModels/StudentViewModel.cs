using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Education_platform.ViewModels
{
    public class StudentViewModel :EditImageViewModel
    {
        [StringLength(25)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(11)]
        [Required]
        public string Phone { get; set; }
        [StringLength(50)]
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Gender { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile photo { get; set; }
    }
}
