using Mechinetest.Models;
using System.ComponentModel.DataAnnotations;

namespace Mechinetest.Models
{
    public class QualificationViewModel
    {
        [Required(ErrorMessage = "Course Name is required")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Percentage is required")]
        public decimal Percentage { get; set; }

        [Required(ErrorMessage = "Year of Passing is required")]
        public int YearOfPassing { get; set; }
    }
}
