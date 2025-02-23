using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class SignUpFormViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
        public string PasswordConfirm { get; set; }
        public IFormFile Image { get; set; }
    }
}