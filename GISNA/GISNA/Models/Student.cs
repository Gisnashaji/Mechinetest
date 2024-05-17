using System.ComponentModel.DataAnnotations;

namespace GISNA.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Please enter name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please choose gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter date of birth")]
        [Display(Name="Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }


        [Required(ErrorMessage = "Please choose batch time")]
        [Display(Name = "Batch Time")]
        [DataType(DataType.Time)]
        public DateTime BatchTime { get; set; }


        [Required(ErrorMessage = "Please enter Phone Number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Please enter email address")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please enter website url")]
        [Display(Name = "Website Url")]
        [Url]
        public string Website { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirm password")]
        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage ="password and confirm password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
