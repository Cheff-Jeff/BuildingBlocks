using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "This input is required.")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9\.\-]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$", ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This input is required")]
        //[StringLength(100, MinimumLength = 1, ErrorMessage = "Your password must be between 1 and 100 characters long.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}