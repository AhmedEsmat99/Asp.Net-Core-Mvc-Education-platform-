using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Education_platform.ViewModels
{
    public class RegisterAccount
    {
        [DataType(DataType.EmailAddress)]
        [Remote(action: "CheckEmail", controller: "Account", AdditionalFields = "Email", ErrorMessage = "The Email already exists")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
