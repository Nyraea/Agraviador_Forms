using System.ComponentModel.DataAnnotations;

namespace Agraviador_Forms.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "User name")]
        [Required(ErrorMessage = "a username is required")]

        public string? Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "a password is required")]
        public string? Password { get; set; }
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "you must confirm your password")]
        public string? ConfirmPassword { get; set; }
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Email address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "email address is required")]

        public string? Email { get; set; }

        [RegularExpression("[0=9]{3}-[0-9]{3}-[0-9]{4}", ErrorMessage = "You must follow the format 000-000-0000")]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
    }
}
