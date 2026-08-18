using System.ComponentModel.DataAnnotations;

namespace Book_api_core.Models
{
    public class SignUpDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        public string RepeatPassword { get; set; }
    }
}