using System.ComponentModel.DataAnnotations;

namespace Education_platform.Models
{
    public class RoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
