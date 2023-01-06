using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Education_platform.ViewModels
{
    public class DepartmentViewModel : EditImageViewModel
    {
        [Required]
        public string NameDepratment { get; set; }
        [Required]
        public string NameManger { get; set; }
        [Required]
        public string Description { get; set; }
        [Display(Name = "Picture")]
        [DataType(DataType.Upload)]
        public IFormFile Image { get; set; }
    }
}
