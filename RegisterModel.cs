using System.ComponentModel.DataAnnotations;

namespace Final_project.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10,15}$", ErrorMessage = "Phone number must be numeric")]
        public string? PhoneNo { get; set; }
    }
}
