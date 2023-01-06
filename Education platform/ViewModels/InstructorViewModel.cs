using Education_platform.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Education_platform.ViewModels
{
	public class InstructorViewModel : EditImageViewModel
	{
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        [Range(15, 35)]
        public int Age { get; set; }
        [StringLength(11)]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [StringLength(50)]
        public string Adress { get; set; }
        public IFormFile Image { get; set; }
        [Display(Name ="Department")]
        public int Idept { get; set; }
        public int IdInst { get; set; }
        public int IdCrs { get; set; }
    }
}
