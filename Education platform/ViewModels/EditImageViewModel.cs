using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Education_platform.ViewModels
{
    public class EditImageViewModel  : RegisterAccount
    {
        public int Id { get; set; }
        [Display(Name = "Picture")]
        public string ExistingImage { get; set; }
    }
}
