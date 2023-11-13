using System.ComponentModel.DataAnnotations;

namespace Agraviador_Forms.Models
{
    public enum Ranks
    {
        Probationary, Permanent
    }

    public class Instructor
    {


        [Required]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Is tenured")]
        public bool IsTenured { get; set; }

        [Required]
        [Display(Name = "Academic Rank")]
        public Ranks Rank { get; set; }

        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        [RegularExpression ("[0=9]{3}-[0-9]{3}-[0-9]{4}", ErrorMessage = "You must follow the format 000-000-0000")]
        [Display (Name = "Office Phone Number")]
        public string? PhoneNumber { get; set; }

        [EmailAddress]
        [Display (Name = "Email Address")]
        public string? Email { get; set; }

        [Url]
        [Display(Name = "Personal Webpage")]
        public string? PersonalURL { get; set; }

        public int SalaryPerHour { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        [Display (Name = "Password (we won't use this!)")]
        [DataType(DataType.Password)]
        public string? UnusedPassword { get; set; }
    }
}

