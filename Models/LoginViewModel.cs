using System.ComponentModel.DataAnnotations;

namespace Agraviador_Forms.Models
{
    public class LoginViewModel
    {
        [Display(Name = "User name")]
        [Required(ErrorMessage = "Username is required!")]
        public string? Username { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required!")]
        public string? Password { get; set; }


        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
