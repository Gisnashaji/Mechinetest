using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace Scope_India.Models
{
    public class RegisterModel
    {

        [Required(ErrorMessage = "Please enter your First Name")]
        [StringLength(100)]  
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Please enter your Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter Date of birth")]

        [Display(Name = "Date of Birth")]

        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }




        [Required(ErrorMessage = "Please choose your gender")]
        public string Gender { get; set; }


       

        [Required(ErrorMessage = "Please enter email address")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [StringLength(100, ErrorMessage = "Email should be no longer than 100 characters.")]
        [Display(Name = "Email Address")]


        public string Email { get; set; }


        [Required(ErrorMessage = "Please enter phone number")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        [StringLength(20, ErrorMessage = "Phone number should be no longer than 20 characters.")]
        [Display(Name = "Phone Number")]



        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Country is required.")]
        [StringLength(50, ErrorMessage = "Country should be no longer than 50 characters.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "State is required.")]
        [StringLength(50, ErrorMessage = "State should be no longer than 50 characters.")]
        public string State { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(50, ErrorMessage = "City should be no longer than 50 characters.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please select at least Three hobbies")]
        public List<string> Hobbies { get; set; }

        public string SelectedHobbies { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Upload Your Image")]
        [Required(ErrorMessage = "Please Upload your avatar image")]
        public byte[] Upload { get; set; } // Updated to byte[] for binary data (image)


        [Required(ErrorMessage = "Please enter password")]

        [DataType(DataType.Password)]
        public string Password { get; set; }

        
        [Required(ErrorMessage = "Please enter confirm password")]

        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match")]
        public string ConfirmPassword { get; set; }

    }
}


