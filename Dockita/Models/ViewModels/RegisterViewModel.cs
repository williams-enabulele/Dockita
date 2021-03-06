using System.ComponentModel.DataAnnotations;

namespace Dockita.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Enter First Name To Continue")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Last Name To Continue")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter Email To Continue")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Password To Continue")]
        public string Password { get; set; }
    }
}