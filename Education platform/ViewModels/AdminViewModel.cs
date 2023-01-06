using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Education_platform.ViewModels
{
    public class AdminViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(11)]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Remote(action: "CheckEmail", controller: "Account", AdditionalFields = "Email", ErrorMessage = "The Email already exists")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
